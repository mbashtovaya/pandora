using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.Storage.v2021_04_01.BlobContainers;


internal class ImmutabilityPolicyPropertiesModel
{
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    [JsonPropertyName("properties")]
    public ImmutabilityPolicyPropertyModel? Properties { get; set; }

    [JsonPropertyName("updateHistory")]
    public List<UpdateHistoryPropertyModel>? UpdateHistory { get; set; }
}