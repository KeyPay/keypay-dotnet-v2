using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.EmployeeRecurringTransactions
{
    public class EmployerRecurringLiabilityModel
    {
        public string EmployerLiabilityCategoryName { get; set; }
        public int EmployerLiabilityCategoryId { get; set; }
        public EmployerRecurringLiabilityTypeEnum LiabilityType { get; set; }
        public string ExternalReferenceId { get; set; }
        public ExternalService Source { get; set; }
        public int? Id { get; set; }
        public int EmployeeId { get; set; }
        public decimal Amount { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime FromDate { get; set; }
        public decimal? MaximumAmountPaid { get; set; }
        public decimal TotalAmountPaid { get; set; }
        public bool IsActive { get; set; }
        public string Notes { get; set; }
    }
}
