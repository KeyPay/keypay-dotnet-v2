using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Manager
{
    public class ShiftNoteViewModel
    {
        public int Id { get; set; }
        public EmployeeViewModel Employee { get; set; }
        public DateTime Date { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public TimeAttendanceShiftNoteType Type { get; set; }
        public string Note { get; set; }
        public int NoteId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public TimeAttendanceShiftNoteVisibility Visibility { get; set; }
        public bool Read { get; set; }
        public bool CreatedByAdmin { get; set; }
    }
}
