using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Ess
{
    public class LeaveApplicationWithAttachmentModel
    {
        public int Id { get; set; }
        public Byte[] Attachment { get; set; }
        public int? AttachmentId { get; set; }
        public string Filename { get; set; }
        public decimal Hours { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int? LeaveCategoryId { get; set; }
        public string Notes { get; set; }
    }
}
