using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Security.v2020_01_01.SecureScoreControlDefinitions;

internal class Definition : ResourceDefinition
{
    public string Name => "SecureScoreControlDefinitions";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new SecureScoreControlDefinitionsListOperation(),
        new SecureScoreControlDefinitionsListBySubscriptionOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(ControlTypeConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(AzureResourceLinkModel),
        typeof(SecureScoreControlDefinitionItemModel),
        typeof(SecureScoreControlDefinitionItemPropertiesModel),
        typeof(SecureScoreControlDefinitionSourceModel),
    };
}
