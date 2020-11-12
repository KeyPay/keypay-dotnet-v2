using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.PayRun
{
    public class ApiPaySlipCpfAdjustmentModel
    {
        public string VoluntaryCpfType { get; set; }
        public string Notes { get; set; }
        public decimal Amount { get; set; }
    }
}
