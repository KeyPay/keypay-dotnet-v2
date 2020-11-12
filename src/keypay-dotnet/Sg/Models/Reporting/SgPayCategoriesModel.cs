using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Reporting
{
    public class SgPayCategoriesModel
    {
        public decimal CpfEmployerContributionAmount { get; set; }
        public decimal CpfEmployeeContributionAmount { get; set; }
        public decimal EmployerVoluntaryCpfAmount { get; set; }
        public decimal EmployerVoluntaryMediSaveAmount { get; set; }
        public decimal SdlContributionAmount { get; set; }
        public string PayCategory { get; set; }
        public string PayRun { get; set; }
        public DateTime DatePaid { get; set; }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string ExternalId { get; set; }
        public string Location { get; set; }
        public decimal Units { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
    }
}
