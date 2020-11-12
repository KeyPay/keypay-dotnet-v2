using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.PayRun
{
    public class PayRunWarningResult
    {
        public string WarningMessage { get; set; }
        public List<PayRunWarningDto> Warnings { get; set; }
        public string TemplateName { get; set; }
    }
}
