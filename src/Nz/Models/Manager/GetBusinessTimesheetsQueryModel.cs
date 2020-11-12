using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Manager
{
    public class GetBusinessTimesheetsQueryModel
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public TimesheetLineStatusType? Status { get; set; }
        public int? EmployeeId { get; set; }
        public int? EmployeeGroupId { get; set; }
        public int? LocationId { get; set; }
        public bool IncludeCosts { get; set; }
        public int? CurrentPage { get; set; }
        public int? PageSize { get; set; }
        public TimesheetGrouping? OrderBy { get; set; }
    }
}
