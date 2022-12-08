using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.RecoveryServicesBackup.v2022_03_01.Operation;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum OverwriteOptionsConstant
{
    [Description("FailOnConflict")]
    FailOnConflict,

    [Description("Invalid")]
    Invalid,

    [Description("Overwrite")]
    Overwrite,
}