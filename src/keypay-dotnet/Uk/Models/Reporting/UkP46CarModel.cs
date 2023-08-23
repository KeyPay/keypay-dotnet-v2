using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class UkP46CarModel
    {
        public int? Id { get; set; }
        public int EmployeeId { get; set; }
        public int BusinessId { get; set; }
        public int EmployeeBenefitCategoryId { get; set; }
        public string EmployeeName { get; set; }
        public bool IsIgnored { get; set; }
        public string CarMakeAndModel { get; set; }
        public string CarRegistrationNumber { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public UkP46CarChangeType ChangeType { get; set; }
        public string ChangeTypeDescription { get; set; }
    }
}
