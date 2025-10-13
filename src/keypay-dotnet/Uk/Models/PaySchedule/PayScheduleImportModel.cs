using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PaySchedule
{
    public class PayScheduleImportModel
    {
        public string Name { get; set; }
        public string Frequency { get; set; }
        public bool? MonthlyPaymentMode { get; set; }
        public bool? ProRataCalculations { get; set; }
        public string UnitType { get; set; }
        public decimal? Unit { get; set; }
        public string QualifyingDays { get; set; }
        public string IncludedEmployees { get; set; }
        public List<Int32> Locations { get; set; }
        public string PaySlipMessage { get; set; }
    }
}
