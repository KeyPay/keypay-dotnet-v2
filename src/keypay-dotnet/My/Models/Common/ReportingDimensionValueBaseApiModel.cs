using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Common
{
    public class ReportingDimensionValueBaseApiModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ReportingDimensionId { get; set; }
    }
}
