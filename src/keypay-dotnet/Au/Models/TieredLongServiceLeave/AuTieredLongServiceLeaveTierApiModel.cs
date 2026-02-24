using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.TieredLongServiceLeave
{
    public class AuTieredLongServiceLeaveTierApiModel
    {
        public int Tier { get; set; }
        public int? ApplicableFromYears { get; set; }
        public int EntitlementAfterYears { get; set; }
        public bool IsRepeatingTier { get; set; }
    }
}
