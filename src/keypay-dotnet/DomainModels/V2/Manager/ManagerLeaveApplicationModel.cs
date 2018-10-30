using System;

namespace KeyPay.DomainModels.V2.Manager
{
    public class ManagerLeaveApplicationModel
    {
        public int? Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public decimal Hours { get; set; }
        public int? LeaveCategoryId { get; set; }
        public string Notes { get; set; }
        public int? AttachmentId { get; set; }
        public byte[] Attachment { get; set; }
    }
}
