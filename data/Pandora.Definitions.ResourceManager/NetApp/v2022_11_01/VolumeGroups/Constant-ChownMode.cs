using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.NetApp.v2022_11_01.VolumeGroups;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ChownModeConstant
{
    [Description("Restricted")]
    Restricted,

    [Description("Unrestricted")]
    Unrestricted,
}
