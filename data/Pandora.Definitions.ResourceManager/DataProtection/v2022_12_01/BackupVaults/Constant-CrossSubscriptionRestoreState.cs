using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.DataProtection.v2022_12_01.BackupVaults;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum CrossSubscriptionRestoreStateConstant
{
    [Description("Disabled")]
    Disabled,

    [Description("Enabled")]
    Enabled,

    [Description("PermanentlyDisabled")]
    PermanentlyDisabled,
}