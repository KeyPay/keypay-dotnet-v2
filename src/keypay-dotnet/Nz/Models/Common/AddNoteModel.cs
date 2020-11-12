using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Common
{
    public class AddNoteModel
    {
        public int EmployeeId { get; set; }
        public TimeAttendanceShiftNoteType Type { get; set; }
        public TimeAttendanceShiftNoteVisibility Visibility { get; set; }
        public string Note { get; set; }
        public bool IsAdminInitiated { get; set; }
    }
}
