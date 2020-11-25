using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.Ess
{
    public class EssPaymentSummaryModel
    {
        public int Id { get; set; }
        public string Period { get; set; }
        public bool IsEtp { get; set; }
        public string EtpCode { get; set; }
    }
}
