using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.RedisEnterprise.v2022_01_01.PrivateEndpointConnections;

internal class Definition : ResourceDefinition
{
    public string Name => "PrivateEndpointConnections";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new DeleteOperation(),
        new GetOperation(),
        new ListOperation(),
        new PutOperation(),
    };
}