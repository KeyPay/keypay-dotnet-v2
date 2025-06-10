using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.ReportingDimensions
{
    public class ReportingDimensionValueFilterApiModel
    {
        public string FilterType { get; set; }
        public string Value { get; set; }
    }
}
