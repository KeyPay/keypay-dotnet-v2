using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.EmploymentAgreement
{
    public class GetShiftPeriodsModel
    {
        public DateTime? FirstShiftStartTime { get; set; }
        public DateTime? LastShiftStartTime { get; set; }
    }
}
