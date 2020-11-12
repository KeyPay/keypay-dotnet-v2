using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.EmploymentAgreement
{
    public class ShiftPeriodModel
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
