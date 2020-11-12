using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.PayRun
{
    public class SubmitPayRunEarningsLineRequest
    {
        public IdType LocationIdType { get; set; }
        public IdType PayCategoryIdType { get; set; }
        public Dictionary<string,List<EarningsLineModel>> EarningsLines { get; set; }
        public int PayRunId { get; set; }
        public IdType EmployeeIdType { get; set; }
        public bool ReplaceExisting { get; set; }
        public bool SuppressCalculations { get; set; }
    }
}
