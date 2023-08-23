using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Manager
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
