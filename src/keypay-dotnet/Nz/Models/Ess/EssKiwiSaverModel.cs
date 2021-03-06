using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Ess
{
    public class EssKiwiSaverModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public KiwiSaverEnrollmentStatusEnum KiwiSaverEnrollmentStatus { get; set; }
        public string KiwiSaverEnrollmentStatusDescription { get; set; }
        public string KiwiSaverIneligibilityReason { get; set; }
        public decimal? EmployeeContribution { get; set; }
        public decimal? EmployerContribution { get; set; }
        public DateTime? OptOutDate { get; set; }
        public DateTime? ContributionHolidayFromDate { get; set; }
        public DateTime? ContributionHolidayToDate { get; set; }
    }
}
