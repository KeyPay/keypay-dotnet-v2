using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.PayRun
{
    public class NzBankPaymentModel
    {
        public string BankCode { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeExternalId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeSurname { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public decimal Amount { get; set; }
        public string AccountType { get; set; }
        public string LodgementReference { get; set; }
    }
}
