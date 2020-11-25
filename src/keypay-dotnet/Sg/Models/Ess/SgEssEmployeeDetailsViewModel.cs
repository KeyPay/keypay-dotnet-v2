using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.Ess
{
    public class SgEssEmployeeDetailsViewModel
    {
        public SgAddressModel ResidentialAddress { get; set; }
        public SgAddressModel PostalAddress { get; set; }
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
