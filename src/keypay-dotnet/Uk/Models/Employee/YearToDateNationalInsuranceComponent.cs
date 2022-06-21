using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class YearToDateNationalInsuranceComponent
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public NationalInsuranceType Category { get; set; }
        public decimal TotalNiablePay { get; set; }
        public decimal Lel { get; set; }
        public decimal LelToPt { get; set; }
        public decimal PtToFust { get; set; }
        public decimal FustToUel { get; set; }
        public decimal AboveUel { get; set; }
        public decimal EmployerNi { get; set; }
        public decimal LelToSt { get; set; }
        public decimal StToFust { get; set; }
        public decimal FustToUst { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public YearToDateComponentType Type { get; set; }
    }
}
