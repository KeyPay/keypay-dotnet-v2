using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.PayRun
{
    public class ApiPaySlipPaygAdjustmentModel
    {
        public string Notes { get; set; }
        public decimal Amount { get; set; }
    }
}
