using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.PayRun
{
    public class NetToGrossRequest
    {
        public decimal NetAmount { get; set; }
        public int PayCategoryId { get; set; }
        public int PayRunTotalId { get; set; }
    }
}
