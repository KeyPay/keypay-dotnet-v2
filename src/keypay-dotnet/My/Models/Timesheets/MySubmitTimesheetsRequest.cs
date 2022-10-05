using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Timesheets
{
    public class MySubmitTimesheetsRequest
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public bool ReplaceExisting { get; set; }
        public bool Approved { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public IdType EmployeeIdType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public IdType LocationIdType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public IdType WorkTypeIdType { get; set; }
        public IDictionary<string,IList<MyTimesheetLineModel>> Timesheets { get; set; }
    }
}
