package processors

import (
	"github.com/hashicorp/pandora/tools/sdk/resourcemanager"
)

type ModelProcessor interface {
	ProcessModel(modelName string, model resourcemanager.TerraformSchemaModelDefinition, models map[string]resourcemanager.TerraformSchemaModelDefinition) (map[string]resourcemanager.TerraformSchemaModelDefinition, error)
}

var ModelRules = []ModelProcessor{
	modelFlattenListReferenceIds{},
	modelFlattenPropertiesIntoParent{},
	modelFlattenReferenceId{},
	modelRemoveStatusAndDetail{},
	modelFlattenSkuName{},
}

func topLevelObjectDefinition(input resourcemanager.TerraformSchemaFieldObjectDefinition) resourcemanager.TerraformSchemaFieldObjectDefinition {
	if input.NestedObject != nil {
		return topLevelObjectDefinition(*input.NestedObject)
	}

	return input
}

func findUnusedModels(topLevelModelName string, input map[string]resourcemanager.TerraformSchemaModelDefinition) map[string]resourcemanager.TerraformSchemaModelDefinition {
	usedModels := map[string]struct{}{
		topLevelModelName: {},
	}
	for _, modelDetails := range input {
		for _, fieldDetails := range modelDetails.Fields {
			topLevelObjectDefinition := topLevelObjectDefinition(fieldDetails.ObjectDefinition)
			if topLevelObjectDefinition.Type == resourcemanager.TerraformSchemaFieldTypeReference {
				// TODO: check if it's a constant
				usedModels[*topLevelObjectDefinition.ReferenceName] = struct{}{}
			}
		}
	}

	output := make(map[string]resourcemanager.TerraformSchemaModelDefinition)
	for modelName := range usedModels {
		output[modelName] = input[modelName]
	}
	return output
}