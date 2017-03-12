using System;

namespace KeyPay.DomainModels.V2.Report
{
    public class BirthdayReportExportModel
    {
        public string Location { get; set; }
        public int EmployeeId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ExternalId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string EmploymentStatus { get; set; }
        public int Age { get; set; }
    }
}