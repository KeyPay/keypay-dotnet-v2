using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Reporting
{
    public class DocumentAcknowledgementsReportQueryModel
    {
        public int? DocumentId { get; set; }
        public List<Int32> EmployeeIds { get; set; }
        public int DocumentStatus { get; set; }
        public int? EmployingEntityId { get; set; }
        public int LocationId { get; set; }
    }
}
