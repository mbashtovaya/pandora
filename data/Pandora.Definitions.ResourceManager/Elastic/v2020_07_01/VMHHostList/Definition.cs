using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.Elastic.v2020_07_01.VMHHostList;

internal class Definition : ResourceDefinition
{
    public string Name => "VMHHostList";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new VMHostListOperation(),
    };
}