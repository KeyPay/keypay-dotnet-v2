using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.EmployingEntities
{
    public class MyEmployingEntityModel
    {
        public string Crn { get; set; }
        public string AddressLine3 { get; set; }
        public string CountryId { get; set; }
        public string BlockNumber { get; set; }
        public string UnitNumber { get; set; }
        public string LevelNumber { get; set; }
        public bool IsInternationalAddress { get; set; }
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
        public string PaySlipFromEmailAddress { get; set; }
    }
}
