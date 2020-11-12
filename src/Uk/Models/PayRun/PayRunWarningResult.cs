using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PayRun
{
    public class PayRunWarningResult
    {
        public string WarningMessage { get; set; }
        public List<PayRunWarningDto> Warnings { get; set; }
        public string TemplateName { get; set; }
    }
}
