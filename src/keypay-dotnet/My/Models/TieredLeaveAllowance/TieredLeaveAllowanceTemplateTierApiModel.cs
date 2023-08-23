using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.TieredLeaveAllowance
{
    public class TieredLeaveAllowanceTemplateTierApiModel
    {
        public int? MinUnit { get; set; }
        public int? MaxUnit { get; set; }
        public int LeaveAllowanceTemplateId { get; set; }
        public string LeaveAllowanceTemplateName { get; set; }
    }
}
