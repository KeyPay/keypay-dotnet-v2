using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.ReportingDimensions
{
    public class ReportingDimensionValueFilterApiModel
    {
        public string FilterType { get; set; }
        public string Value { get; set; }
    }
}
