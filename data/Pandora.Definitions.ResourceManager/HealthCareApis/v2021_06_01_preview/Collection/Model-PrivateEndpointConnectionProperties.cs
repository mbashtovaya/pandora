using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.HealthCareApis.v2021_06_01_preview.Collection;


internal class PrivateEndpointConnectionPropertiesModel
{
    [JsonPropertyName("privateEndpoint")]
    public PrivateEndpointModel? PrivateEndpoint { get; set; }

    [JsonPropertyName("privateLinkServiceConnectionState")]
    [Required]
    public PrivateLinkServiceConnectionStateModel PrivateLinkServiceConnectionState { get; set; }

    [JsonPropertyName("provisioningState")]
    public PrivateEndpointConnectionProvisioningStateConstant? ProvisioningState { get; set; }
}