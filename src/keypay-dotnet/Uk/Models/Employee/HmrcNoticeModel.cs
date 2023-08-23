using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class HmrcNoticeModel
    {
        public DateTime DateApplied { get; set; }
        public string TaxPeriod { get; set; }
        public string NoticeType { get; set; }
        public string NewValue { get; set; }
        public string TaxYear { get; set; }
    }
}
