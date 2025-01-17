using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.KubernetesConfiguration.v2022_11_01.FluxConfiguration;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ScopeTypeConstant
{
    [Description("cluster")]
    Cluster,

    [Description("namespace")]
    Namespace,
}
