using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Ess
{
    public class GetShiftNotesQueryModel
    {
        public int EmployeeId { get; set; }
        public bool IsAdminInitiated { get; set; }
        public TimeAttendanceShiftNoteType? Type { get; set; }
        public TimeAttendanceShiftNoteVisibility? Visibility { get; set; }
    }
}
