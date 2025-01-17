// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum DeviceManagementDerivedCredentialIssuerConstant
{
    [Description("Intercede")]
    @intercede,

    [Description("EntrustDatacard")]
    @entrustDatacard,

    [Description("Purebred")]
    @purebred,

    [Description("XTec")]
    @xTec,
}
