using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.ResourceManager.EventHub.v2021_11_01.NamespacesPrivateEndpointConnections;

internal class PrivateEndpointConnectionsCreateOrUpdateOperation : Operations.PutOperation
{
    public override Type? RequestObject() => typeof(PrivateEndpointConnectionModel);

    public override ResourceID? ResourceId() => new PrivateEndpointConnectionId();

    public override Type? ResponseObject() => typeof(PrivateEndpointConnectionModel);


}