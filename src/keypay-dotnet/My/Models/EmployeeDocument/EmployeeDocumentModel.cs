using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.EmployeeDocument
{
    public class EmployeeDocumentModel
    {
        public int Id { get; set; }
        public string FriendlyName { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Visible { get; set; }
        public int? LeaveRequestId { get; set; }
        public int? TimesheetLineId { get; set; }
    }
}
