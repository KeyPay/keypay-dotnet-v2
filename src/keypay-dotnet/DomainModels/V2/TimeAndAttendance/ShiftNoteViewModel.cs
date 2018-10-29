using System;
using KeyPay.DomainModels.V2.Employee;
using KeyPay.Enums;

namespace KeyPay.DomainModels.V2.TimeAndAttendance
{
    public class ShiftNoteViewModel
    {
        public int Id { get; set; }
        public EmployeeViewModel Employee { get; set; }
        public DateTime Date { get; set; }
        public TimeAttendanceShiftNoteType Type { get; set; }
        public string Note { get; set; }
        public int NoteId { get; set; }
        public TimeAttendanceShiftNoteVisibility Visibility { get; set; }
        public bool Read { get; set; }
        public bool CreatedByAdmin { get; set; }
    }
}