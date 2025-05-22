using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.EmployeeRecurringTransactions
{
    public class AdditionalEarningsInputModel
    {
        public long Id { get; set; }
        public int? PayCategoryId { get; set; }
        public int EmployeeId { get; set; }
        public decimal Amount { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal? MaximumAmountPaid { get; set; }
        public string Notes { get; set; }
        public decimal Units { get; set; }
        public int? LocationId { get; set; }
        public decimal? SuperRate { get; set; }
        public bool OverrideSuperRate { get; set; }
    }
}
