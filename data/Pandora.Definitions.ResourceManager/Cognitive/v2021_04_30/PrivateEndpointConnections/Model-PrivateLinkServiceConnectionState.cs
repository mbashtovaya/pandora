using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.Cognitive.v2021_04_30.PrivateEndpointConnections
{

    internal class PrivateLinkServiceConnectionStateModel
    {
        [JsonPropertyName("actionsRequired")]
        public string? ActionsRequired { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("status")]
        public PrivateEndpointServiceConnectionStatusConstant? Status { get; set; }
    }
}