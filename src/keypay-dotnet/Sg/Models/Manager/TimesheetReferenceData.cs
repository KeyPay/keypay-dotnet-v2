using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Manager
{
    public class TimesheetReferenceData
    {
        public List<EssWorkTypeModel> WorkTypes { get; set; }
        public List<EssWorkTypeModel> ShiftConditions { get; set; }
        public List<LocationModel> Locations { get; set; }
        public IList<ClassificationSelectModel> Classifications { get; set; }
    }
}
