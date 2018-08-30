using System;

namespace KeyPay.DomainModels.V2.Manager
{
    public class AttachmentModel
    {
        public int? Id { get; set; }
        public string FriendlyName { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Url { get; set; }
    }
}