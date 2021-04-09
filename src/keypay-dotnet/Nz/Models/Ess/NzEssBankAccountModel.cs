using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Ess
{
    public class NzEssBankAccountModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public BankAccountTypeEnum AccountType { get; set; }
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Bsb { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public decimal? AllocatedPercentage { get; set; }
        public decimal? FixedAmount { get; set; }
        public bool AllocateBalance { get; set; }
        public bool IsEmployeeEditable { get; set; }
        public bool CanBeDeleted { get; set; }
        public string ExternalReferenceId { get; set; }
    }
}
