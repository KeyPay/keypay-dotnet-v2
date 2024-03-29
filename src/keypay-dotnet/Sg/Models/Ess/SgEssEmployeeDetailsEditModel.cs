using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Ess
{
    public class SgEssEmployeeDetailsEditModel
    {
        public SgAddressModel ResidentialAddress { get; set; }
        public SgAddressModel PostalAddress { get; set; }
        public string LegalName { get; set; }
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
