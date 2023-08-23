using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Common
{
    public class UkEmployeeBenefitCategoryExtLoanEditModel
    {
        public int? NumberOfJointBorrowers { get; set; }
        public decimal AmountOutstandingAtStartOfYearOrLoan { get; set; }
        public decimal AmountOutstandingAtEndOfYearOrLoan { get; set; }
        public decimal MaximumAmountOutstandingDuringTheYear { get; set; }
        public DateTime? DateLoanWasMadeIfThisYear { get; set; }
        public DateTime? DateLoanWasDischargedIfThisYear { get; set; }
        public decimal InterestRate { get; set; }
        public decimal? AmountForegoneUserEntered { get; set; }
        public decimal InterestDue { get; set; }
    }
}
