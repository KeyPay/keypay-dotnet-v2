using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.Reporting
{
    public class SgWithholdingModel
    {
        public string Location { get; set; }
        public string Month { get; set; }
        public decimal GrossEarnings { get; set; }
        public decimal WithholdingTaxAmount { get; set; }
        public decimal ClearanceTaxAmount { get; set; }
    }
}
