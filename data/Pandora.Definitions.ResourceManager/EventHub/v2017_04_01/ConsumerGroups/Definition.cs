using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.EventHub.v2017_04_01.ConsumerGroups
{
    internal class Definition : ApiDefinition
    {
        // Generated from Swagger revision "60d6c393c7e71b45ebe0976a35fd7a5841993159" 

        public string ApiVersion => "2017-04-01";
        public string Name => "ConsumerGroups";
        public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
        {
            new CreateOrUpdateOperation(),
            new DeleteOperation(),
            new GetOperation(),
            new ListByEventHubOperation(),
        };
    }
}
