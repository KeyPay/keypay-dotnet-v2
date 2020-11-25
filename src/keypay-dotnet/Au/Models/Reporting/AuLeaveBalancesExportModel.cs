using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;
using MidpointRounding = KeyPayV2.Au.Enums.MidpointRounding;

namespace KeyPayV2.Au.Models.Reporting
{
    public class AuLeaveBalancesExportModel
    {
        public decimal AccruedAmountInDays { get; set; }
        public decimal LeaveValue { get; set; }
        public decimal LoadingValue { get; set; }
        public decimal LeavePlusLoading { get; set; }
        public int EmployeeId { get; set; }
        public string ExternalId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Location { get; set; }
        public string LeaveCategoryName { get; set; }
        public decimal AccruedAmount { get; set; }
        public decimal AccruedAmountInHours { get; set; }
        public LeaveUnitTypeEnum UnitType { get; set; }
    }
}
