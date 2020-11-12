using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.EmployingEntities
{
    public class AuEmployingEntityModel
    {
        public string Abn { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string BranchCode { get; set; }
        public bool IsExemptFromFringeBenefitsTax { get; set; }
        public bool HasSeparateEntertainmentFringeBenefitsCap { get; set; }
        public FbtExemptOrganisationTypeEnum? FbtExemptOrganisationType { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactName { get; set; }
        public string SignatoryName { get; set; }
        public string ContactEmailAddress { get; set; }
        public string ContactPhoneNumber { get; set; }
        public string ContactFaxNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Postcode { get; set; }
        public string ExternalReferenceId { get; set; }
    }
}
