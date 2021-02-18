using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.EmployeeRecurringTransactions
{
    public class EmployeeRecurringTaxAdjustmentModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public TaxAdjustmentTypeEnum AdjustmentType { get; set; }
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
