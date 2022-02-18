using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.KubernetesConfiguration.v2021_09_01.ClusterExtensions;


internal class PatchExtensionModel
{
    [JsonPropertyName("properties")]
    public PatchExtensionPropertiesModel? Properties { get; set; }
}