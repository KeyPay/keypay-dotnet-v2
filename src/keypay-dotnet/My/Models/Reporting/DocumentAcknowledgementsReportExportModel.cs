using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Reporting
{
    public class DocumentAcknowledgementsReportExportModel
    {
        public string Status { get; set; }
        public string DocumentName { get; set; }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string ExternalId { get; set; }
        public DateTime? LastNotification { get; set; }
        public string LocationName { get; set; }
    }
}
