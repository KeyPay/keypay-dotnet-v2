using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Other
{
    public class MyEssStatutoryDetailsModel
    {
        public string Itn { get; set; }
        public int? EmploymentType { get; set; }
        public string EmploymentTypeDescription { get; set; }
        public int WorkerStatus { get; set; }
        public string WorkerStatusDescription { get; set; }
        public string Nationality { get; set; }
        public int ResidenceStatus { get; set; }
        public string ResidenceStatusDescription { get; set; }
        public int ResidenceType { get; set; }
        public string ResidenceTypeDescription { get; set; }
        public string IdentityCardNumber { get; set; }
        public string PassportNumber { get; set; }
        public string PassportIssuingCountry { get; set; }
        public DateTime? PassportExpiry { get; set; }
        public int? WorkPassType { get; set; }
        public string WorkPassTypeDescription { get; set; }
        public bool? ApplyOld11PercentForNonMalaysian { get; set; }
        public int? SocsoScheme { get; set; }
        public string SocsoSchemeDescription { get; set; }
        public string SocialSecurityForeignWorkerNumber { get; set; }
        public string EpfNumber { get; set; }
        public int? EpfContributionType { get; set; }
        public string EpfContributionTypeDescription { get; set; }
        public int? EpfRate { get; set; }
        public string EpfRateDescription { get; set; }
        public int MaritalStatus { get; set; }
        public string MaritalStatusDescription { get; set; }
        public int DependentChildren { get; set; }
        public string SpouseFirstName { get; set; }
        public string SpouseSurname { get; set; }
        public int? SpouseResidenceStatus { get; set; }
        public string SpouseResidenceStatusDescription { get; set; }
        public string SpouseIdentityCardNumber { get; set; }
        public string SpousePassportNumber { get; set; }
        public string SpouseItn { get; set; }
        public bool EisExempt { get; set; }
        public bool PcbBorneByEmployer { get; set; }
    }
}
