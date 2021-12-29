using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.EmployeeRecurringTransactions
{
    public class AdditionalEarningsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? PayCategoryId { get; set; }
        public int EmployeeId { get; set; }
        public decimal Amount { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal? MaximumAmountPaid { get; set; }
        public bool IsActive { get; set; }
        public string Notes { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ExpirationTypeEnum ExpirationType { get; set; }
        public decimal TotalAmountPaid { get; set; }
        public decimal Units { get; set; }
        public int? LocationId { get; set; }
        public string LocationName { get; set; }
        public decimal? SuperRate { get; set; }
        public bool OverrideSuperRate { get; set; }
    }
}
