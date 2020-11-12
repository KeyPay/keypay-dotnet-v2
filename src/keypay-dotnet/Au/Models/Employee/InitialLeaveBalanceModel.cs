using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Employee
{
    public class InitialLeaveBalanceModel
    {
        public int LeaveCategoryId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public LeaveUnitTypeEnum UnitType { get; set; }
    }
}
