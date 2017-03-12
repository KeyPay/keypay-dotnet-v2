using System;

namespace KeyPay.DomainModels.V2.Employee
{
    public class EmployeeNoteModel
    {
        public int Id { get; set; }
        public string User { get; set; }
        public DateTime DateTime { get; set; }
        public string Note { get; set; }
    }
}