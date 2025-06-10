using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class UkNationalInsuranceBackCalculationPeriodModel
    {
        public string PayPeriod { get; set; }
        public DateTime Date { get; set; }
        public decimal GrossPay { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public NationalInsuranceType OriginalCategory { get; set; }
        public decimal OriginalEmployeeNI { get; set; }
        public decimal OriginalEmployerNI { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public NationalInsuranceType NewCategory { get; set; }
        public decimal NewEmployeeNI { get; set; }
        public decimal NewEmployerNI { get; set; }
    }
}
