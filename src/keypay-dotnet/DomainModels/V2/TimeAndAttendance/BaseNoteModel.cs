using KeyPay.Enums;

namespace KeyPay.DomainModels.V2.TimeAndAttendance
{
    public class BaseNoteModel
    {
        public bool IsAdminInitiated { get; set; }
    }
    
    public class AddNoteModel : BaseNoteModel
    {
        public AddNoteModel()
        {
            Visibility = TimeAttendanceShiftNoteVisibility.Visible; // Visible by default
        }

        public int EmployeeId { get; set; }
        public TimeAttendanceShiftNoteType Type { get; set; }
        public TimeAttendanceShiftNoteVisibility Visibility { get; set; }
        public string Note { get; set; }
    }
}