using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.ResourceManager.CostManagement.v2021_10_01.Exports
{
    internal class ListOperation : Operations.GetOperation
    {
        public override ResourceID? ResourceId() => new ScopeId();

        public override Type? ResponseObject() => typeof(ExportListResultModel);

        public override Type? OptionsObject() => typeof(ListOperation.ListOptions);

        public override string? UriSuffix() => "/providers/Microsoft.CostManagement/exports";

        internal class ListOptions
        {
            [QueryStringName("$expand")]
            [Optional]
            public string Expand { get; set; }
        }
    }
}