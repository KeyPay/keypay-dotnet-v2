using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.PayRun
{
    public class ApiPaySlipDeductionModel
    {
        public string Notes { get; set; }
        public decimal Amount { get; set; }
        public string TaxStatus { get; set; }
        public string Name { get; set; }
    }
}
