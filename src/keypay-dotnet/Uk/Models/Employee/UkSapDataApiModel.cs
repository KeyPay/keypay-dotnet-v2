using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.Employee
{
    public class UkSapDataApiModel
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsSurrogacy { get; set; }
        public DateTime BabyDueDate { get; set; }
        public decimal WeeksPaid { get; set; }
        public decimal? WeeksToPay { get; set; }
        public DateTime? PrevSapStartDate { get; set; }
        public DateTime? PrevSapEndDate { get; set; }
        public decimal? AverageWeeklyEarningsOverride { get; set; }
        public decimal? EmployerPensionProtection { get; set; }
        public SapCalculationTypeEnum? CalculationType { get; set; }
        public bool OffsetSap { get; set; }
        public bool PayLumpSum { get; set; }
        public IList<UkSapApiModel> Sap { get; set; }
        public DoNotPaySapReasonEnum? DoNotPayReason { get; set; }
        public decimal? SapAdjust { get; set; }
        public string Notes { get; set; }
    }
}
