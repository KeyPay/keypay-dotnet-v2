using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Reporting
{
    public class GetShiftSwappingReportByBusinessIdQueryModel
    {
        public int? FromEmployeeId { get; set; }
        public int? ToEmployeeId { get; set; }
        public bool IncludeCosts { get; set; }
        public IList<RosterShiftSwapStatusEnum> Statuses { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int LocationId { get; set; }
        public int? EmployingEntityId { get; set; }
    }
}
