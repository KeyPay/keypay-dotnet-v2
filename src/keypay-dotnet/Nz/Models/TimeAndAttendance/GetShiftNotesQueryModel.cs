using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.TimeAndAttendance
{
    public class GetShiftNotesQueryModel
    {
        public int EmployeeId { get; set; }
        public bool IsAdminInitiated { get; set; }
        public TimeAttendanceShiftNoteType? Type { get; set; }
        public TimeAttendanceShiftNoteVisibility? Visibility { get; set; }
    }
}
