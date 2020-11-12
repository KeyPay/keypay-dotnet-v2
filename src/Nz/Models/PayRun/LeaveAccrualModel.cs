using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.PayRun
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
