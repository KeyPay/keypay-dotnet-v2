using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Ess
{
    public class EssPaymentSummaryModel
    {
        public int Id { get; set; }
        public string Period { get; set; }
        public bool IsEtp { get; set; }
        public string EtpCode { get; set; }
    }
}
