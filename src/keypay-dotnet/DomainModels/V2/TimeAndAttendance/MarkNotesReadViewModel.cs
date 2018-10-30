namespace KeyPay.DomainModels.V2.TimeAndAttendance
{
    public class MarkNotesReadViewModel
    {
        public int EmployeeId { get; set; }
        public int[] NoteIds { get; set; }
        public bool Read { get; set; }
    }
}