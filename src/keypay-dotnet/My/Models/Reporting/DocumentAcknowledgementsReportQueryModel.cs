using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Reporting
{
    public class DocumentAcknowledgementsReportQueryModel
    {
        public int? DocumentId { get; set; }
        public List<Int32> EmployeeIds { get; set; }
        public int DocumentStatus { get; set; }
        public int EmployingEntityId { get; set; }
        public int LocationId { get; set; }
    }
}
