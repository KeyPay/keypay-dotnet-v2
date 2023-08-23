using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Ess
{
    public class BankAccountEditModel
    {
        public int Id { get; set; }
        public string Bsb { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public decimal? AllocatedPercentage { get; set; }
        public decimal? FixedAmount { get; set; }
        public string ExternalReferenceId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ExternalService Source { get; set; }
        public bool AllocateBalance { get; set; }
        public bool IsEmployeeEditable { get; set; }
        public bool CanBeDeleted { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public BankAccountTypeEnum AccountType { get; set; }
        public string RollNumber { get; set; }
        public string BankSwift { get; set; }
        public string BranchCode { get; set; }
        public string MyBankCode { get; set; }
        public string MyOtherBankName { get; set; }
        public string MdmId { get; set; }
        public int? MdmVersion { get; set; }
        public string MdmSchemaVersion { get; set; }
        public bool TriggeredFromMdm { get; set; }
        public bool SendToMdm { get; set; }
        public IDictionary<String,String> IgnoreFields { get; set; }
    }
}
