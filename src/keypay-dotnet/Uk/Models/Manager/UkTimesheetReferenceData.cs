using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Manager
{
    public class UkTimesheetReferenceData
    {
        public List<UkEssWorkTypeModel> WorkTypes { get; set; }
        public List<UkEssWorkTypeModel> ShiftConditions { get; set; }
        public List<LocationModel> Locations { get; set; }
        public IList<ReportingDimensionValueSelectModel> DimensionValues { get; set; }
    }
}
