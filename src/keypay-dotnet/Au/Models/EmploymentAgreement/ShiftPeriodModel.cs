using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.EmploymentAgreement
{
    public class ShiftPeriodModel
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
