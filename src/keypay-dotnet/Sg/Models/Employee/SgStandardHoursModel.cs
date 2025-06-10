using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Employee
{
    public class SgStandardHoursModel
    {
        public List<Decimal> AdvancedHoursPerWeeks { get; set; }
        public DateTime? StandardHoursReferenceDate { get; set; }
        public int EmployeeId { get; set; }
        public decimal StandardHoursPerWeek { get; set; }
        public decimal StandardHoursPerDay { get; set; }
        public bool UseAdvancedWorkWeek { get; set; }
        public List<StandardHoursDayModel> StandardWorkDays { get; set; }
        public decimal? FullTimeEquivalentHours { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public AdvancedWorkWeekConfigurationOption? AdvancedWorkWeekConfiguration { get; set; }
    }
}
