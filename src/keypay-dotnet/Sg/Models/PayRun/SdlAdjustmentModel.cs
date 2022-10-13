using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.PayRun
{
    public class SdlAdjustmentModel
    {
        public int Id { get; set; }
        public string Notes { get; set; }
        public decimal? AdjustmentAmount { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
    }
}
