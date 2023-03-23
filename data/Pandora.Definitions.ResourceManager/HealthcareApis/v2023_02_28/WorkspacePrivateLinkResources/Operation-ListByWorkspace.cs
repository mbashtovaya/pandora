using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.HealthcareApis.v2023_02_28.WorkspacePrivateLinkResources;

internal class ListByWorkspaceOperation : Operations.GetOperation
{
    public override ResourceID? ResourceId() => new WorkspaceId();

    public override Type? ResponseObject() => typeof(PrivateLinkResourceListResultDescriptionModel);

    public override string? UriSuffix() => "/privateLinkResources";


}
