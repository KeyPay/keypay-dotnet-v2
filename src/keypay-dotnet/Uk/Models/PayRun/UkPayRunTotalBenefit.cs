using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PayRun
{
    public class UkPayRunTotalBenefit
    {
        public int EmployeeId { get; set; }
        public int BenefitCategoryId { get; set; }
        public string BenefitType { get; set; }
        public string BenefitName { get; set; }
        public decimal Amount { get; set; }
        public bool IsFirstTimePayrolled { get; set; }
    }
}
