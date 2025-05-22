using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.ReportingDimensions
{
    public class ReportingDimensionValueFilterApiModel
    {
        public string FilterType { get; set; }
        public string Value { get; set; }
    }
}
