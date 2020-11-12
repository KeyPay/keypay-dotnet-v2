using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class HmrcFormsViewModel
    {
        public IList<P60GridViewModel> P60s { get; set; }
        public bool HasP45 { get; set; }
        public P45ViewModel P45 { get; set; }
        public bool HasP60s { get; set; }
        public AutoEnrolmentNoticeViewModel AutoEnrolmentData { get; set; }
    }
}
