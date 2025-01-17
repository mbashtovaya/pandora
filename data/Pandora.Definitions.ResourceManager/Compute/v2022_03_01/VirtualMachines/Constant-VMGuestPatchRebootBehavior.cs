using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Compute.v2022_03_01.VirtualMachines;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum VMGuestPatchRebootBehaviorConstant
{
    [Description("AlwaysRequiresReboot")]
    AlwaysRequiresReboot,

    [Description("CanRequestReboot")]
    CanRequestReboot,

    [Description("NeverReboots")]
    NeverReboots,

    [Description("Unknown")]
    Unknown,
}
