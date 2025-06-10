using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.EmployeeQualifications
{
    public class EmployeeQualificationRequest
    {
        public int QualificationId { get; set; }
        public string Name { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime? IssueDate { get; set; }
        public string ReferenceNumber { get; set; }
    }
}
