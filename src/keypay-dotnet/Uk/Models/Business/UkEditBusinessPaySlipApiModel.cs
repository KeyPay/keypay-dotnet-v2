using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Business
{
    public class UkEditBusinessPaySlipApiModel
    {
        public bool ShowEmployeeAddress { get; set; }
        public bool ShowCrnNumber { get; set; }
        public bool ShowPayeReference { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PaySlipFormat PaySlipFormat { get; set; }
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
