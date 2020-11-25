using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;
using MidpointRounding = KeyPayV2.Au.Enums.MidpointRounding;

namespace KeyPayV2.Au.Models.Common
{
    public class LeaveBalanceModel
    {
        public int LeaveCategoryId { get; set; }
        public string LeaveCategoryName { get; set; }
        public decimal AccruedAmount { get; set; }
        public LeaveUnitTypeEnum UnitType { get; set; }
    }
}
