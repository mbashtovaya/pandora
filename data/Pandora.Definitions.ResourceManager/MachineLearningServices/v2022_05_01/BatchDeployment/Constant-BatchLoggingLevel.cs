using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2022_05_01.BatchDeployment;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum BatchLoggingLevelConstant
{
    [Description("Debug")]
    Debug,

    [Description("Info")]
    Info,

    [Description("Warning")]
    Warning,
}
