using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;
using MidpointRounding = KeyPayV2.Nz.Enums.MidpointRounding;

namespace KeyPayV2.Nz.Models.Employee
{
    public class NzInitialDeductionModel
    {
        public bool TaxExempt { get; set; }
        public int DeductionCategoryId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
}
