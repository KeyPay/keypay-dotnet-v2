using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Reporting
{
    public class EmployeeDetailsReportQueryModel
    {
        public List<String> SelectedColumns { get; set; }
        public int LocationId { get; set; }
        public int? EmployingEntityId { get; set; }
        public bool IncludeActive { get; set; }
        public bool IncludeInactive { get; set; }
    }
}
