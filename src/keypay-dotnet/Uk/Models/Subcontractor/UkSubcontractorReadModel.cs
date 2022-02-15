using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Subcontractor
{
    public class UkSubcontractorReadModel
    {
        public int EmployeeId { get; set; }
        public string TradingName { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public SubcontractorBusinessType BusinessType { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string OtherName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Town { get; set; }
        public string Postcode { get; set; }
        public string County { get; set; }
        public string CountryId { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string UniqueTaxpayerReference { get; set; }
        public string NationalInsuranceNumber { get; set; }
        public string CompanyRegistrationNumber { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public SubcontractorTaxStatus TaxStatus { get; set; }
        public DateTime? DateMatched { get; set; }
        public string VerificationNumber { get; set; }
        public bool IsContractAgreed { get; set; }
    }
}
