using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.PayRun
{
    public class LeaveAccrualModel
    {
        public int Id { get; set; }
        public string LeaveCategoryName { get; set; }
        public string LeaveCategoryId { get; set; }
        public decimal Amount { get; set; }
        public string Notes { get; set; }
        public string AccrualType { get; set; }
    }
}
