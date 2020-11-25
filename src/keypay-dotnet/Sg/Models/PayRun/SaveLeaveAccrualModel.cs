using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.PayRun
{
    public class SaveLeaveAccrualModel
    {
        public SaveLeaveAccrualTypeEnum AccrualType { get; set; }
        public string Notes { get; set; }
        public decimal Amount { get; set; }
        public int LeaveCategoryId { get; set; }
        public bool ApplyLeaveLoading { get; set; }
        public bool AdjustEarnings { get; set; }
        public string ExternalReferenceId { get; set; }
    }
}
