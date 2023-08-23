using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Other
{
    public class P11GenerationModel
    {
        public int TaxYear { get; set; }
        public int PayScheduleId { get; set; }
        public int LocationId { get; set; }
        public List<Int32> EmployeeIds { get; set; }
    }
}
