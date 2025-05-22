using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Manager
{
    public class MyTimesheetReferenceData
    {
        public List<MyEssWorkTypeModel> WorkTypes { get; set; }
        public List<MyEssWorkTypeModel> ShiftConditions { get; set; }
        public List<LocationModel> Locations { get; set; }
        public IList<ReportingDimensionValueSelectModel> DimensionValues { get; set; }
    }
}
