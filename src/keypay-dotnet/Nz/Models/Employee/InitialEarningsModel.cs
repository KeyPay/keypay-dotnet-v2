using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Employee
{
    public class InitialEarningsModel
    {
        public int PayCategoryId { get; set; }
        public bool IsStandardPayCategory { get; set; }
        public PayCategoryType PayCategoryType { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
}
