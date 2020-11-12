using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class OpeningPensionsModel
    {
        public decimal? TaxReliefPensionAmount { get; set; }
        public decimal? EmployerPensionContributionAmount { get; set; }
        public decimal? EmployeePensionContributionAmount { get; set; }
    }
}
