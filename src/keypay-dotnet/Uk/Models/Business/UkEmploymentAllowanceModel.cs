using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Business
{
    public class UkEmploymentAllowanceModel
    {
        public DateTime? EmpAllowanceEffectiveDate { get; set; }
        public decimal EmpAllowanceClaimedInPreviousPayrollPeriod { get; set; }
        public bool EmpAllowanceClaimedInAnotherPayrollProductThisTaxYear { get; set; }
        public List<String> StateAidSector { get; set; }
        public bool StateAidRulesDoNotApply { get; set; }
        public bool IncludeEmploymentAllowanceInJournals { get; set; }
    }
}
