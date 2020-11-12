using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class UkLeaveBalancesExportModel
    {
        public decimal LeaveValue { get; set; }
        public int EmployeeId { get; set; }
        public string ExternalId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Location { get; set; }
        public string LeaveCategoryName { get; set; }
        public decimal AccruedAmount { get; set; }
        public decimal AccruedAmountInDays { get; set; }
    }
}
