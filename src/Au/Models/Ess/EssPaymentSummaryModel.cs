using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Ess
{
    public class EssPaymentSummaryModel
    {
        public int Id { get; set; }
        public string Period { get; set; }
        public bool IsEtp { get; set; }
        public string EtpCode { get; set; }
    }
}
