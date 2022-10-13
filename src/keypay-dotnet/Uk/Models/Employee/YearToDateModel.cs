using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class YearToDateModel
    {
        public YearToDateGrossPaySection GrossPay { get; set; }
        public YearToDateNationalInsuranceSection NationalInsurance { get; set; }
        public YearToDateDefaultSection StatutoryPay { get; set; }
        public YearToDateTaxSection Tax { get; set; }
        public YearToDatePensionSection Pension { get; set; }
        public YearToDateAnnotatedSection Deductions { get; set; }
        public YearToDateLinkSection NetPay { get; set; }
    }
}
