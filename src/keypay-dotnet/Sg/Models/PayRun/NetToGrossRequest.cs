using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.PayRun
{
    public class NetToGrossRequest
    {
        public decimal NetAmount { get; set; }
        public int PayCategoryId { get; set; }
        public int PayRunTotalId { get; set; }
    }
}
