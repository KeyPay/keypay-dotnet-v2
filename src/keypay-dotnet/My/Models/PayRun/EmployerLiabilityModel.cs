using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.PayRun
{
    public class EmployerLiabilityModel
    {
        public string EmployerLiabilityCategoryId { get; set; }
        public string EmployerLiabilityCategoryName { get; set; }
        public string Notes { get; set; }
        public decimal Amount { get; set; }
        public int Id { get; set; }
        public string ExternalId { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeExternalId { get; set; }
    }
}
