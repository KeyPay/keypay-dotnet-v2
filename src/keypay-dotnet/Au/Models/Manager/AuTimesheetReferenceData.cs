using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Manager
{
    public class AuTimesheetReferenceData
    {
        public IList<ClassificationSelectModel> Classifications { get; set; }
        public List<AuEssWorkTypeModel> WorkTypes { get; set; }
        public List<AuEssWorkTypeModel> ShiftConditions { get; set; }
        public List<LocationModel> Locations { get; set; }
        public IList<ReportingDimensionValueSelectModel> DimensionValues { get; set; }
    }
}
