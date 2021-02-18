using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Manager
{
    public class ManagerLeaveApplicationModel
    {
        public Byte[] Attachment { get; set; }
        public int? AttachmentId { get; set; }
        public string Filename { get; set; }
        public decimal Hours { get; set; }
        public decimal Units { get; set; }
        public int Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int? LeaveCategoryId { get; set; }
        public string Notes { get; set; }
    }
}
