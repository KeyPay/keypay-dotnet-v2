using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.Reporting
{
    public class SgPaymentHistoryModel
    {
        public string BankSwift { get; set; }
        public string BranchCode { get; set; }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string ExternalId { get; set; }
        public DateTime DatePaid { get; set; }
        public string LocationName { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public decimal TaxableEarnings { get; set; }
        public decimal NetEarnings { get; set; }
        public decimal TotalAllowances { get; set; }
        public decimal TotalDeductions { get; set; }
        public decimal Amount { get; set; }
    }
}
