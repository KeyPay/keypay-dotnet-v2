using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Common
{
    public class WorkTypeSelectModel
    {
        public bool IsUnitBased { get; set; }
        public bool IsLeaveType { get; set; }
        public string UnitType { get; set; }
        public int? BusinessAwardPackageId { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
