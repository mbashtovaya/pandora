using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.MachineLearningServices.v2023_04_01_preview.OnlineDeployment;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum EndpointComputeTypeConstant
{
    [Description("AzureMLCompute")]
    AzureMLCompute,

    [Description("Kubernetes")]
    Kubernetes,

    [Description("Managed")]
    Managed,
}
