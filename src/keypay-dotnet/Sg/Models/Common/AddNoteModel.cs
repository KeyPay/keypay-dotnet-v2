using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Common
{
    public class AddNoteModel
    {
        public int EmployeeId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public TimeAttendanceShiftNoteType Type { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public TimeAttendanceShiftNoteVisibility Visibility { get; set; }
        public string Note { get; set; }
        public bool IsAdminInitiated { get; set; }
    }
}
