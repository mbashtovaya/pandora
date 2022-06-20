using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2022_05_01.BatchDeployment;

internal class DeploymentId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/batchEndpoints/{endpointName}/deployments/{deploymentName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticSubscriptions", "subscriptions"),
        ResourceIDSegment.SubscriptionId("subscriptionId"),
        ResourceIDSegment.Static("staticResourceGroups", "resourceGroups"),
        ResourceIDSegment.ResourceGroup("resourceGroupName"),
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticMicrosoftMachineLearningServices", "Microsoft.MachineLearningServices"),
        ResourceIDSegment.Static("staticWorkspaces", "workspaces"),
        ResourceIDSegment.UserSpecified("workspaceName"),
        ResourceIDSegment.Static("staticBatchEndpoints", "batchEndpoints"),
        ResourceIDSegment.UserSpecified("endpointName"),
        ResourceIDSegment.Static("staticDeployments", "deployments"),
        ResourceIDSegment.UserSpecified("deploymentName"),
    };
}
