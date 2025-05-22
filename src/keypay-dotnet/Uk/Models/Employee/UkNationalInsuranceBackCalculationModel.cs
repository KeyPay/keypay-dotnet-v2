using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class UkNationalInsuranceBackCalculationModel
    {
        public DateTime StartDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsInitialised { get; set; }
        public bool IsCompleted { get; set; }
        public IList<UkNationalInsuranceBackCalculationPeriodModel> Periods { get; set; }
        public decimal TotalOriginalEmployeeNI { get; set; }
        public decimal TotalOriginalEmployerNI { get; set; }
        public decimal TotalNewEmployeeNI { get; set; }
        public decimal TotalNewEmployerNI { get; set; }
        public decimal TotalAmountDueEmployee { get; set; }
        public decimal TotalAmountDueEmployer { get; set; }
    }
}
