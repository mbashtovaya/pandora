using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.RedisEnterprise.v2021_08_01.PrivateEndpointConnections
{
    internal class Definition : ApiDefinition
    {
        public string ApiVersion => "2021-08-01";
        public string Name => "PrivateEndpointConnections";
        public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
        {
            new DeleteOperation(),
            new GetOperation(),
            new ListOperation(),
            new PutOperation(),
        };
    }
}
