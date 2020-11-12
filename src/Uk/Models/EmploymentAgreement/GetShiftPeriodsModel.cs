using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.EmploymentAgreement
{
    public class GetShiftPeriodsModel
    {
        public DateTime? FirstShiftStartTime { get; set; }
        public DateTime? LastShiftStartTime { get; set; }
    }
}
