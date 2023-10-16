using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Common
{
    public class ReportingDimensionValueSelectModel
    {
        public int ReportingDimensionId { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsNoLongerAllowed { get; set; }
        public int? Value { get; set; }
        public string Text { get; set; }
    }
}
