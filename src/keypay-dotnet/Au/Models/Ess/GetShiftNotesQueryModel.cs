using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Ess
{
    public class GetShiftNotesQueryModel
    {
        public int EmployeeId { get; set; }
        public bool IsAdminInitiated { get; set; }
        public TimeAttendanceShiftNoteType? Type { get; set; }
        public TimeAttendanceShiftNoteVisibility? Visibility { get; set; }
    }
}
