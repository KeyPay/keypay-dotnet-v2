using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Other
{
    public class GetPaySlipsByFinalisedPayRunIdQueryModel
    {
        public int PayRunId { get; set; }
        public int? EmployeeId { get; set; }
        public int LocationId { get; set; }
        public int? EmployingEntityId { get; set; }
    }
}
