using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.TimeAndAttendance
{
    public class GetShiftNotesQueryModel
    {
        public int EmployeeId { get; set; }
        public bool IsAdminInitiated { get; set; }
        public TimeAttendanceShiftNoteType? Type { get; set; }
        public TimeAttendanceShiftNoteVisibility? Visibility { get; set; }
    }
}
