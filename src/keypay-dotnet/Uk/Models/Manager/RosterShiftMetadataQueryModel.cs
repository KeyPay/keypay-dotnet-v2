using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Manager
{
    public class RosterShiftMetadataQueryModel
    {
        public DateTime Date { get; set; }
        public int? EmployeeId { get; set; }
        public int? LocationId { get; set; }
        public int? RoleId { get; set; }
        public bool? IncludeCosts { get; set; }
        public bool? IncludeSubLocations { get; set; }
    }
}
