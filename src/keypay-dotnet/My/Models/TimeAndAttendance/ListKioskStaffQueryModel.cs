using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.TimeAndAttendance
{
    public class ListKioskStaffQueryModel
    {
        public bool RestrictCurrentShiftsToCurrentKioskLocation { get; set; }
    }
}
