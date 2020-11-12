using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Reporting
{
    public class KiwiSaverReportExportModel
    {
        public string Location { get; set; }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string KiwiSaverEnrollmentStatus { get; set; }
        public string KiwiSaverIneligibilityReason { get; set; }
        public decimal EmployeeContributionPercent { get; set; }
        public decimal EmployerContributionPercent { get; set; }
        public string OptOutDate { get; set; }
        public string ContributionHolidayFromDate { get; set; }
        public string ContributionHolidayToDate { get; set; }
        public decimal KiwiSaverEmployeeContributionAmount { get; set; }
        public decimal KiwiSaverEmployerContributionAmount { get; set; }
        public decimal EsctContributionAmount { get; set; }
        public decimal TotalKiwiSaver { get; set; }
    }
}
