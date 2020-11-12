using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Common
{
    public class SaveSuperFundModel
    {
        public string MemberNumber { get; set; }
        public decimal? AllocatedPercentage { get; set; }
        public decimal? FixedAmount { get; set; }
        public string ProductCode { get; set; }
        public string FundName { get; set; }
        public bool AllocateBalance { get; set; }
        public bool? IsEmployerNominatedFund { get; set; }
    }
}
