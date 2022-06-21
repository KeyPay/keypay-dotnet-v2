using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Ess
{
    public class EssEmployeeQualificationModel
    {
        public int Id { get; set; }
        public int QualificationId { get; set; }
        public string Name { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime? IssueDate { get; set; }
        public IList<EssEmployeeQualificationDocumentModel> Documents { get; set; }
        public string ReferenceNumber { get; set; }
        public bool HasQualification { get; set; }
        public bool IsExpired { get; set; }
        public bool IsExpiring { get; set; }
    }
}
