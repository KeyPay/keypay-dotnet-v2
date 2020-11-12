using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Business
{
    public class HmrcSettingsModel
    {
        public string TaxOfficeNumber { get; set; }
        public string TaxOfficeReference { get; set; }
        public string AccountsOfficeReference { get; set; }
        public string RtiUserId { get; set; }
        public string RtiPassword { get; set; }
        public bool IsAgent { get; set; }
        public string BusinessName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Suburb { get; set; }
        public string Country { get; set; }
        public bool IsRtiEnabled { get; set; }
        public bool RtiTestMode { get; set; }
        public bool ClaimSmallEmployersRelief { get; set; }
        public bool ClaimEmploymentAllowance { get; set; }
        public int EpsSubmissionDay { get; set; }
        public string EpsAccountName { get; set; }
        public string EpsAccountNumber { get; set; }
        public string EpsAccountSortCode { get; set; }
        public string EpsAccountBuildingSocietyRef { get; set; }
        public bool RequiredToPayApprenticeshipLevy { get; set; }
        public decimal? ApprenticeshipLevyAllowance { get; set; }
        public bool AlreadyReportedApprenticeshipLevy { get; set; }
        public decimal? PreviouslyReportedApprenticeshipLevyAllowance { get; set; }
        public decimal? PreviouslyReportedApprenticeshipLevyAmount { get; set; }
    }
}
