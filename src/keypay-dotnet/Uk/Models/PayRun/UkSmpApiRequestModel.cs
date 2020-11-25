using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.PayRun
{
    public class UkSmpApiRequestModel
    {
        public int LeaveDataId { get; set; }
        public int LeaveAccrualId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal? Rate { get; set; }
        public SmpPayTypeEnum PayType { get; set; }
        public DoNotPaySmpReasonEnum? DoNotPayReason { get; set; }
    }
}
