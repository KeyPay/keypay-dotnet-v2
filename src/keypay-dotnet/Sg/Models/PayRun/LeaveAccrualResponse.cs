using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.PayRun
{
    public class LeaveAccrualResponse
    {
        public int PayRunId { get; set; }
        public Dictionary<string,List<LeaveAccrualModel>> Leave { get; set; }
    }
}
