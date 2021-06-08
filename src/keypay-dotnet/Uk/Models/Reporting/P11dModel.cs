using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class P11dModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int BusinessId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public P11DStatus Status { get; set; }
        public DateTime? NotificationDate { get; set; }
        public DateTime? DateGenerated { get; set; }
        public string EmployeeName { get; set; }
        public bool IsCompanyDirector { get; set; }
        public string NationalInsuranceNumber { get; set; }
        public decimal SumOfCashEquivalents { get; set; }
        public int TaxYear { get; set; }
        public DateTime? TerminationDate { get; set; }
        public bool IsCurrent { get; set; }
        public string DownloadUrl { get; set; }
        public string PreviewUrl { get; set; }
    }
}
