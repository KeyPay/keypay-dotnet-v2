using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Ess
{
    public class EssLeaveCategoryModel
    {
        public LeaveUnitTypeEnum UnitType { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
