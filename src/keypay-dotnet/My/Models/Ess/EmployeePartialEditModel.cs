using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Ess
{
    public class EmployeePartialEditModel
    {
        public int Id { get; set; }
        public DateTime? AnniversaryDate { get; set; }
        public string ExternalId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int BusinessId { get; set; }
        public string TaxFileNumber { get; set; }
        public string TaxFileNumberMasked { get; set; }
        public IList<BankAccountEditModel> BankAccounts { get; set; }
        public string ExternalReferenceId { get; set; }
        public string PayrollId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public EmployeeStarterTypeEnum EmployeeStarterType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ExternalService Source { get; set; }
        public string TagsString { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public EmployeeTimesheetSetting TimesheetSetting { get; set; }
        public string TerminationReason { get; set; }
        public string PortableLongServiceLeaveId { get; set; }
        public bool IncludeInPortableLongServiceLeaveReport { get; set; }
        public int? TitleId { get; set; }
        public string FirstName { get; set; }
        public string OtherName { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public string PreviousSurname { get; set; }
        public string LegalName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string ResidentialStreetAddress { get; set; }
        public string ResidentialAddressLine2 { get; set; }
        public int? ResidentialSuburbId { get; set; }
        public string ResidentialSuburb { get; set; }
        public string ResidentialState { get; set; }
        public string ResidentialPostcode { get; set; }
        public string ResidentialCountry { get; set; }
        public string ResidentialCountryId { get; set; }
        public bool IsOverseasResidentialAddress { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public AddressTypeEnum? ResidentialAddressType { get; set; }
        public string ResidentialBlockNumber { get; set; }
        public string ResidentialLevelNumber { get; set; }
        public string ResidentialUnitNumber { get; set; }
        public string ResidentialStreetName { get; set; }
        public string ResidentialAddressLine3 { get; set; }
        public string PostalStreetAddress { get; set; }
        public string PostalAddressLine2 { get; set; }
        public int? PostalSuburbId { get; set; }
        public string PostalSuburb { get; set; }
        public string PostalState { get; set; }
        public string PostalPostcode { get; set; }
        public string PostalCountry { get; set; }
        public string PostalCountryId { get; set; }
        public bool IsOverseasPostalAddress { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public AddressTypeEnum? PostalAddressType { get; set; }
        public string PostalBlockNumber { get; set; }
        public string PostalLevelNumber { get; set; }
        public string PostalUnitNumber { get; set; }
        public string PostalStreetName { get; set; }
        public string PostalAddressLine3 { get; set; }
        public bool IsPostalAddressSameAsResidential { get; set; }
        public string Email { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string MobilePhone { get; set; }
        public string ResidentialAddress_MdmId { get; set; }
        public int? ResidentialAddress_MdmVersion { get; set; }
        public string ResidentialAddress_MdmSchemaVersion { get; set; }
        public string PostalAddress_MdmId { get; set; }
        public int? PostalAddress_MdmVersion { get; set; }
        public string PostalAddress_MdmSchemaVersion { get; set; }
        public bool TriggeredFromMdm { get; set; }
        public bool SendToMdm { get; set; }
        public IDictionary<String,String> IgnoreFields { get; set; }
        public bool MdmSyncUser { get; set; }
    }
}
