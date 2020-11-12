using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Business
{
    public class AuStpRegistrationModel
    {
        public string Name { get; set; }
        public string Branch { get; set; }
        public string Abn { get; set; }
        public string ContactName { get; set; }
        public string ContactPhoneNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int? SuburbId { get; set; }
        public string Suburb { get; set; }
        public string PostCode { get; set; }
        public string State { get; set; }
        public AtoSupplierRole LodgementRole { get; set; }
        public string TaxAgentNumber { get; set; }
        public string IntermediaryAbn { get; set; }
        public string IntermediaryContactName { get; set; }
        public string IntermediaryContactEmail { get; set; }
        public string IntermediaryContactPhone { get; set; }
        public AtoIntegrationOption AtoIntegrationOption { get; set; }
        public string SbrSoftwareId { get; set; }
        public bool SbrEnabled { get; set; }
        public bool SingleTouchPayrollEnabled { get; set; }
    }
}
