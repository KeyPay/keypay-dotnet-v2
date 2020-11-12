using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Common
{
    public class SuperFundModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string MemberNumber { get; set; }
        public decimal? AllocatedPercentage { get; set; }
        public decimal? FixedAmount { get; set; }
        public SuperProductModel SuperProduct { get; set; }
        public bool AllocateBalance { get; set; }
        public bool CanBeDeleted { get; set; }
        public bool? IsEmployerNominatedFund { get; set; }
    }
}
