using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Common
{
    public class PartiallyAppliedLeaveRequestBannerModel
    {
        public string Header { get; set; }
        public IList<String> Items { get; set; }
    }
}
