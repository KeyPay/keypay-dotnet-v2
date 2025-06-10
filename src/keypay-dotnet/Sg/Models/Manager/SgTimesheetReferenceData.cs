using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Manager
{
    public class SgTimesheetReferenceData
    {
        public List<SgEssWorkTypeModel> WorkTypes { get; set; }
        public List<SgEssWorkTypeModel> ShiftConditions { get; set; }
        public List<LocationModel> Locations { get; set; }
        public IList<ReportingDimensionValueSelectModel> DimensionValues { get; set; }
    }
}
