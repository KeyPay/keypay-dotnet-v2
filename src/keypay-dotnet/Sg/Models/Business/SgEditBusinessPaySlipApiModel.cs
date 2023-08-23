using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Business
{
    public class SgEditBusinessPaySlipApiModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public NricPayslipSettings NricNumberSettings { get; set; }
        public bool ShowClassification { get; set; }
        public bool ShowBasePayRate { get; set; }
        public bool ShowEmployeeId { get; set; }
        public bool ShowRateForAnnualEarnings { get; set; }
        public bool ShowEmployeeAddress { get; set; }
        public bool? ShowYtdTotals { get; set; }
        public bool? ShowUnitsWorked { get; set; }
        public bool? ShowEmployeeStartEndDates { get; set; }
        public int Id { get; set; }
        public string EmailFrom { get; set; }
        public string EmailBodyMessage { get; set; }
        public bool ShowLeaveAccruals { get; set; }
        public bool ShowLineNotes { get; set; }
        public bool ShowLocationInLineNotes { get; set; }
        public bool AlphabetisePayCategories { get; set; }
        public bool ShowEmployeeExternalId { get; set; }
        public bool EmployeesMustLoginToDownloadPayslips { get; set; }
    }
}
