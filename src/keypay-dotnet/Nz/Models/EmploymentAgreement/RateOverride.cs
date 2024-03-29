using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.EmploymentAgreement
{
    public class RateOverride
    {
        public int PayCategoryId { get; set; }
        public decimal Rate { get; set; }
        public bool? UseRateAsIs { get; set; }
    }
}
