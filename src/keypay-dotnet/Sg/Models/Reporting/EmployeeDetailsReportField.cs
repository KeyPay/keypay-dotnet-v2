using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.Reporting
{
    public class EmployeeDetailsReportField
    {
        public string Value { get; set; }
        public string DisplayText { get; set; }
    }
}
