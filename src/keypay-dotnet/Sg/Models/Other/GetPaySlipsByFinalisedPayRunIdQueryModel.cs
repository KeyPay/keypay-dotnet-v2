using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Other
{
    public class GetPaySlipsByFinalisedPayRunIdQueryModel
    {
        public int PayRunId { get; set; }
        public int? EmployeeId { get; set; }
        public int LocationId { get; set; }
        public int? EmployingEntityId { get; set; }
    }
}
