using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.PayRun
{
    public class PayRunWarningResult
    {
        public string WarningMessage { get; set; }
        public List<PayRunWarningDto> Warnings { get; set; }
        public string TemplateName { get; set; }
    }
}
