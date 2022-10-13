using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Common
{
    public class SelfManagedSuperFundModel
    {
        public int Id { get; set; }
        public string Abn { get; set; }
        public string FundName { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string Bsb { get; set; }
        public string ElectronicServiceAddress { get; set; }
        public string Email { get; set; }
        public int? EmployeeId { get; set; }
        public string ExternalId { get; set; }
    }
}
