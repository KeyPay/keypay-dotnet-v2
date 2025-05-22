using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.ReportingDimensions
{
    public class ReportingDimensionValueFilterApiModel
    {
        public string FilterType { get; set; }
        public string Value { get; set; }
    }
}
