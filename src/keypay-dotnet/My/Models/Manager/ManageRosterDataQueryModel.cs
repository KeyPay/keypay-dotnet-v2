using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Manager
{
    public class ManageRosterDataQueryModel
    {
        public DateTime Date { get; set; }
        public int? EmployeeId { get; set; }
        public int? LocationId { get; set; }
        public int? RoleId { get; set; }
        public bool? IncludeCosts { get; set; }
        public bool? IncludeSubLocations { get; set; }
    }
}
