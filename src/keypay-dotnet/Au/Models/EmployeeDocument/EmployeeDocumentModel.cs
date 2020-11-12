using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.EmployeeDocument
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
