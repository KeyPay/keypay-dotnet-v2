using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class UkOccupationalMaternityLeaveDataApiModel
    {
        public int? LeaveCategoryId { get; set; }
        public bool OverrideServiceBand { get; set; }
        public int? OverriddenServiceBandId { get; set; }
        public int? ServiceBandId { get; set; }
        public decimal? OmpAdjust { get; set; }
        public bool SalaryIsOverridden { get; set; }
        public decimal? OverriddenSalary { get; set; }
    }
}
