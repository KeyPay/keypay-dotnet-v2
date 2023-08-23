using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.PayRun
{
    public class NetToGrossRequest
    {
        public decimal NetAmount { get; set; }
        public int PayCategoryId { get; set; }
        public int PayRunTotalId { get; set; }
    }
}
