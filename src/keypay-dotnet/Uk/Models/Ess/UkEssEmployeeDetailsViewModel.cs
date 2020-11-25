using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.Ess
{
    public class UkEssEmployeeDetailsViewModel
    {
        public UkAddressModel ResidentialAddress { get; set; }
        public UkAddressModel PostalAddress { get; set; }
        public bool CanEdit { get; set; }
        public bool HasProfileImage { get; set; }
        public bool CanEditProfileImage { get; set; }
        public DateTime? AnniversaryDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int Id { get; set; }
        public int? TitleId { get; set; }
        public string FirstName { get; set; }
        public string OtherName { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public string PreviousSurname { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string MobilePhone { get; set; }
        public bool? IsPostalAddressSameAsResidential { get; set; }
    }
}
