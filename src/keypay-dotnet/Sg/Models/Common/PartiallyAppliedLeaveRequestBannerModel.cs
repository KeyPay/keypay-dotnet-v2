using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Common
{
    public class PartiallyAppliedLeaveRequestBannerModel
    {
        public string Header { get; set; }
        public IList<String> Items { get; set; }
    }
}
