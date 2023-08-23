using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Reporting
{
    public class BirthdayReportExportModel
    {
        public string Location { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string ExternalId { get; set; }
        public string EmploymentStatus { get; set; }
        public int Age { get; set; }
    }
}
