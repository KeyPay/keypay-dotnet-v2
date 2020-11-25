using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.Employee
{
    public class SgInitialDeductionModel
    {
        public int DeductionCategoryId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
}
