using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Employee
{
    public class GetLeaveBalancesQueryModel
    {
        public DateTime? AsAtDate { get; set; }
        public bool AmalgamateCalculatedAccruals { get; set; }
    }
}
