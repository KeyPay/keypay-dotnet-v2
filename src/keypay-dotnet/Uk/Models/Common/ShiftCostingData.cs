using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Common
{
    public class ShiftCostingData
    {
        public IList<ShiftPartModel> ShiftParts { get; set; }
        public IList<ShiftAllowanceModel> Allowances { get; set; }
        public IList<ShiftLiabilityModel> Liabilities { get; set; }
        public bool IsConsolidated { get; set; }
    }
}
