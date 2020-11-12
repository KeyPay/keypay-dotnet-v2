using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Employee
{
    public class InitialDeductionModel
    {
        public int DeductionCategoryId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public bool IsRESC { get; set; }
        public bool TaxExempt { get; set; }
        public bool IsMemberVoluntary { get; set; }
    }
}
