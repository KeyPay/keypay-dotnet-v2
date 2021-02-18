using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Common
{
    public class WorkTypeSelectModel
    {
        public bool IsUnitBased { get; set; }
        public bool IsLeaveType { get; set; }
        public string UnitType { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
