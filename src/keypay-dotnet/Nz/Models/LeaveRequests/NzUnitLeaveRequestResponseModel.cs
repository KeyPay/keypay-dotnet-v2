using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.LeaveRequests
{
    public class NzUnitLeaveRequestResponseModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveUnitTypeEnum LeaveUnitType { get; set; }
        public decimal TotalUnits { get; set; }
        public decimal UnitsApplied { get; set; }
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int LeaveCategoryId { get; set; }
        public string Employee { get; set; }
        public string LeaveCategory { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }
        public int? AttachmentId { get; set; }
    }
}
