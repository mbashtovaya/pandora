using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.AppConfiguration.v2020_06_01.PrivateEndpointConnections
{
    internal class PrivateEndpointConnectionId : ResourceID
    {
        public string? CommonAlias => null;

        public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppConfiguration/configurationStores/{configStoreName}/privateEndpointConnections/{privateEndpointConnectionName}";

        public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
        {
                new()
                {
                    Name = "subscriptions",
                    Type = ResourceIDSegmentType.Static,
                    FixedValue = "subscriptions"
                },

                new()
                {
                    Name = "subscriptionId",
                    Type = ResourceIDSegmentType.SubscriptionId
                },

                new()
                {
                    Name = "resourceGroups",
                    Type = ResourceIDSegmentType.Static,
                    FixedValue = "resourceGroups"
                },

                new()
                {
                    Name = "resourceGroupName",
                    Type = ResourceIDSegmentType.ResourceGroup
                },

                new()
                {
                    Name = "providers",
                    Type = ResourceIDSegmentType.Static,
                    FixedValue = "providers"
                },

                new()
                {
                    Name = "microsoftAppConfiguration",
                    Type = ResourceIDSegmentType.ResourceProvider,
                    FixedValue = "Microsoft.AppConfiguration"
                },

                new()
                {
                    Name = "configurationStores",
                    Type = ResourceIDSegmentType.Static,
                    FixedValue = "configurationStores"
                },

                new()
                {
                    Name = "configStoreName",
                    Type = ResourceIDSegmentType.UserSpecified
                },

                new()
                {
                    Name = "privateEndpointConnections",
                    Type = ResourceIDSegmentType.Static,
                    FixedValue = "privateEndpointConnections"
                },

                new()
                {
                    Name = "privateEndpointConnectionName",
                    Type = ResourceIDSegmentType.UserSpecified
                },

        };
    }
}
