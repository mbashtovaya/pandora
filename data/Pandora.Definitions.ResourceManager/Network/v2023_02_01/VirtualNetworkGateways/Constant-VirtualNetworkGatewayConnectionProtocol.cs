using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2023_02_01.VirtualNetworkGateways;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum VirtualNetworkGatewayConnectionProtocolConstant
{
    [Description("IKEv1")]
    IKEvOne,

    [Description("IKEv2")]
    IKEvTwo,
}
