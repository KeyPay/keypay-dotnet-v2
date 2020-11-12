using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Common
{
    public class EmployeeDetailsModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string PreferredName { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? AnniversaryDate { get; set; }
        public string ExternalId { get; set; }
        public string ResidentialStreetAddress { get; set; }
        public string ResidentialAddressLine2 { get; set; }
        public string ResidentialSuburb { get; set; }
        public string ResidentialState { get; set; }
        public string ResidentialPostCode { get; set; }
        public string PostalStreetAddress { get; set; }
        public string PostalAddressLine2 { get; set; }
        public string PostalSuburb { get; set; }
        public string PostalState { get; set; }
        public string PostalPostCode { get; set; }
        public string EmailAddress { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string MobilePhone { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ResidentialCity { get; set; }
        public string ResidentialCounty { get; set; }
        public string PostalCity { get; set; }
        public string PostalCounty { get; set; }
    }
}
