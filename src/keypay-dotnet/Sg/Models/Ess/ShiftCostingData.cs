using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Ess
{
    public class ShiftCostingData
    {
        public IList<ShiftPartModel> ShiftParts { get; set; }
        public IList<ShiftAllowanceModel> Allowances { get; set; }
        public IList<ShiftLiabilityModel> Liabilities { get; set; }
        public bool IsConsolidated { get; set; }
    }
}
