using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class UkSppDataApiModel
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime BabyDueDate { get; set; }
        public decimal WeeksPaid { get; set; }
        public decimal? WeeksToPay { get; set; }
        public DateTime? PrevSppStartDate { get; set; }
        public DateTime? PrevSppEndDate { get; set; }
        public decimal? AverageWeeklyEarningsOverride { get; set; }
        public decimal? EmployerPensionProtection { get; set; }
        public bool OffsetSpp { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public BasicPayAdjustmentTypeEnum BasicPayAdjustmentType { get; set; }
        public bool PayLumpSum { get; set; }
        public IList<UkSppApiModel> Spp { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public DoNotPaySppReasonEnum? DoNotPayReason { get; set; }
        public decimal? SppAdjust { get; set; }
        public string Notes { get; set; }
        public bool IsAdoption { get; set; }
    }
}
