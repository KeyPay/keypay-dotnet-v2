using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Common
{
    public class SuperProductModel
    {
        public int Id { get; set; }
        public string Abn { get; set; }
        public string ProductCode { get; set; }
        public string ProductType { get; set; }
        public string BusinessName { get; set; }
        public string DisplayName { get; set; }
        public string ProductName { get; set; }
        public string AccountNumber { get; set; }
        public string Bsb { get; set; }
        public string AccountName { get; set; }
        public ExternalService Source { get; set; }
        public string ElectronicServiceAddress { get; set; }
        public string Email { get; set; }
        public string ExternalReferenceId { get; set; }
    }
}
