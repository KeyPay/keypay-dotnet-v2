using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.PayRun
{
    public class DeductionModel
    {
        public string DeductionCategoryId { get; set; }
        public string DeductionCategoryName { get; set; }
        public decimal Amount { get; set; }
        public string Notes { get; set; }
        public string PaymentReference { get; set; }
        public string Note { get; set; }
        public string PayToBankAccountBSB { get; set; }
        public string PayToBankAccountNumber { get; set; }
        public string PayToSuperFundName { get; set; }
        public string PayToSuperFundMemberNumber { get; set; }
        public string PayTo { get; set; }
        public int? AdditionalData { get; set; }
        public int Id { get; set; }
        public string ExternalId { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeExternalId { get; set; }
    }
}
