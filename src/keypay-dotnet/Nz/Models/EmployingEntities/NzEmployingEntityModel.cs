using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.EmployingEntities
{
    public class NzEmployingEntityModel
    {
        public string Nzbn { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public bool CharitableOrganisation { get; set; }
        public string AddressLine3 { get; set; }
        public FbtExemptOrganisationTypeEnum? OrganisationType { get; set; }
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
