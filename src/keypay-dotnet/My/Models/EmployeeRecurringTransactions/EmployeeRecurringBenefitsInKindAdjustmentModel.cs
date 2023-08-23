using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.EmployeeRecurringTransactions
{
    public class EmployeeRecurringBenefitsInKindAdjustmentModel
    {
        public bool Taxable { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public MyBenefitsInKindType Type { get; set; }
        public string Specify { get; set; }
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
