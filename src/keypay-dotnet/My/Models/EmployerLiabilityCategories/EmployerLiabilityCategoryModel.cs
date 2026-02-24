using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.EmployerLiabilityCategories
{
    public class EmployerLiabilityCategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ExternalReferenceId { get; set; }
        public bool CanBeDeleted { get; set; }
        public bool HideFromPaySlips { get; set; }
        public bool ShowTotalPayments { get; set; }
        public bool IncludeInShiftCosts { get; set; }
        public bool IsSuperannuationFund { get; set; }
    }
}
