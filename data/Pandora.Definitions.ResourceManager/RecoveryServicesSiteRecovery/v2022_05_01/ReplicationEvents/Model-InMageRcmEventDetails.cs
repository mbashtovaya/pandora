using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.RecoveryServicesSiteRecovery.v2022_05_01.ReplicationEvents;

[ValueForType("InMageRcm")]
internal class InMageRcmEventDetailsModel : EventProviderSpecificDetailsModel
{
    [JsonPropertyName("applianceName")]
    public string? ApplianceName { get; set; }

    [JsonPropertyName("componentDisplayName")]
    public string? ComponentDisplayName { get; set; }

    [JsonPropertyName("fabricName")]
    public string? FabricName { get; set; }

    [JsonPropertyName("jobId")]
    public string? JobId { get; set; }

    [JsonPropertyName("latestAgentVersion")]
    public string? LatestAgentVersion { get; set; }

    [JsonPropertyName("protectedItemName")]
    public string? ProtectedItemName { get; set; }

    [JsonPropertyName("serverType")]
    public string? ServerType { get; set; }

    [JsonPropertyName("vmName")]
    public string? VirtualMachineName { get; set; }
}