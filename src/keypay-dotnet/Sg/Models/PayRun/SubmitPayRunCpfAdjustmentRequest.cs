using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.PayRun
{
    public class SubmitPayRunCpfAdjustmentRequest
    {
        public Dictionary<string,List<CpfAdjustmentModel>> CpfAdjustments { get; set; }
        public int PayRunId { get; set; }
        public IdType EmployeeIdType { get; set; }
        public bool ReplaceExisting { get; set; }
        public bool SuppressCalculations { get; set; }
    }
}
