using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Other
{
    public class ReportsShiftSwapping_GetQueryModel
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
