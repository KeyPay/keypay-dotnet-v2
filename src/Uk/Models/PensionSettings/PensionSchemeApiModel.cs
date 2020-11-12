using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PensionSettings
{
    public class PensionSchemeApiModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProviderName { get; set; }
        public string ProviderId { get; set; }
        public string EmployerNumber { get; set; }
        public string ContactInformation { get; set; }
        public string AdminTitle { get; set; }
        public string AdminFirstName { get; set; }
        public string AdminSurname { get; set; }
        public string AdminEmailAddress { get; set; }
        public string AdminPhoneNumber { get; set; }
        public string AdminAddressLine1 { get; set; }
        public string AdminAddressLine2 { get; set; }
        public string AdminSuburb { get; set; }
        public string AdminPostcode { get; set; }
        public string AdminAutoEnrolmentSignatoryFullname { get; set; }
        public string AdminAutoEnrolmentSignatoryTitle { get; set; }
        public string AdminAutoEnrolmentSignatoryEmailAddress { get; set; }
    }
}
