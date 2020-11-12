using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Reporting
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
