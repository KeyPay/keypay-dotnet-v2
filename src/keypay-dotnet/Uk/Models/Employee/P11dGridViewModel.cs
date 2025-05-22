using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class P11dGridViewModel
    {
        public int Id { get; set; }
        public int TaxYearEnding { get; set; }
        public int TaxYear { get; set; }
        public string DownloadUrl { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public P11DStatus CurrentState { get; set; }
        public DateTime DateGenerated { get; set; }
        public DateTime? NotificationDate { get; set; }
        public bool IsPublished { get; set; }
        public string Text { get; set; }
        public int EmployeeId { get; set; }
    }
}
