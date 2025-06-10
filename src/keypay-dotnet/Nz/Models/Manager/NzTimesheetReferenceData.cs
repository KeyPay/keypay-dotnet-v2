using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Manager
{
    public class NzTimesheetReferenceData
    {
        public List<NzEssWorkTypeModel> WorkTypes { get; set; }
        public List<NzEssWorkTypeModel> ShiftConditions { get; set; }
        public List<LocationModel> Locations { get; set; }
        public IList<ReportingDimensionValueSelectModel> DimensionValues { get; set; }
    }
}
