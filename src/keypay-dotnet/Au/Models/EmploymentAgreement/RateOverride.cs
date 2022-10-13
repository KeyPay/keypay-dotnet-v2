using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.EmploymentAgreement
{
    public class RateOverride
    {
        public int PayCategoryId { get; set; }
        public decimal Rate { get; set; }
        public bool? UseRateAsIs { get; set; }
    }
}
