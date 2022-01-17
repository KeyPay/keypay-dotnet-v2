using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Ess
{
    public class EssEmployeeDetailsModel
    {
        public int Id { get; set; }
        public int? TitleId { get; set; }
        public string FirstName { get; set; }
        public string OtherName { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public string PreviousSurname { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? AnniversaryDate { get; set; }
        public string ExternalId { get; set; }
        public string ResidentialStreetAddress { get; set; }
        public string ResidentialAddressLine2 { get; set; }
        public int? ResidentialSuburbId { get; set; }
        public string ResidentialSuburb { get; set; }
        public string ResidentialState { get; set; }
        public string ResidentialPostcode { get; set; }
        public string ResidentialCountry { get; set; }
        public string ResidentialCountryId { get; set; }
        public bool IsOverseasResidentialAddress { get; set; }
        public string PostalStreetAddress { get; set; }
        public string PostalAddressLine2 { get; set; }
        public int? PostalSuburbId { get; set; }
        public string PostalSuburb { get; set; }
        public string PostalState { get; set; }
        public string PostalPostcode { get; set; }
        public string PostalCountry { get; set; }
        public string PostalCountryId { get; set; }
        public bool IsOverseasPostalAddress { get; set; }
        public string Email { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string MobilePhone { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsTerminated { get; set; }
        public bool IsAnonymised { get; set; }
        public string ExternalReferenceId { get; set; }
        public int Source { get; set; }
        public bool IsPostalAddressSameAsResidential { get; set; }
        public IList<TitleViewModel> Titles { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public EmployeeDetailsEditMode EditMode { get; set; }
        public bool CanEdit { get; set; }
        public string TagsString { get; set; }
        public IList<String> AllTags { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public EmployeeTimesheetSetting TimesheetSetting { get; set; }
        public bool CanDelete { get; set; }
        public bool HasProfileImage { get; set; }
        public bool CanEditProfileImage { get; set; }
        public bool BouncedEmail { get; set; }
        public bool IrdDetailsCurrent { get; set; }
        public bool IrdSettingsEnabled { get; set; }
        public bool HasConnectedDevices { get; set; }
        public IList<SelectListItem> AddressTypes { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public AddressTypeEnum? ResidentialAddressType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public AddressTypeEnum? PostalAddressType { get; set; }
        public string ResidentialBlockNumber { get; set; }
        public string PostalBlockNumber { get; set; }
        public string ResidentialLevelNumber { get; set; }
        public string PostalLevelNumber { get; set; }
        public string ResidentialUnitNumber { get; set; }
        public string PostalUnitNumber { get; set; }
        public string ResidentialStreetName { get; set; }
        public string PostalStreetName { get; set; }
        public string ResidentialAddressLine3 { get; set; }
        public string PostalAddressLine3 { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public TerminationReasonEnum TerminationReason { get; set; }
        public string TerminationDescription { get; set; }
        public IList<NumericSelectListItem> TerminationReasons { get; set; }
        public bool HasSoleUser { get; set; }
    }
}
