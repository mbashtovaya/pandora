using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Synapse.v2021_06_01.SqlPoolsSensitivityLabels;

internal class SqlPoolSensitivityLabelsListRecommendedOperation : Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override ResourceID? ResourceId() => new SqlPoolId();

    public override Type NestedItemType() => typeof(SensitivityLabelModel);

    public override Type? OptionsObject() => typeof(SqlPoolSensitivityLabelsListRecommendedOperation.SqlPoolSensitivityLabelsListRecommendedOptions);

    public override string? UriSuffix() => "/recommendedSensitivityLabels";

    internal class SqlPoolSensitivityLabelsListRecommendedOptions
    {
        [QueryStringName("$filter")]
        [Optional]
        public string Filter { get; set; }

        [QueryStringName("includeDisabledRecommendations")]
        [Optional]
        public bool IncludeDisabledRecommendations { get; set; }
    }
}