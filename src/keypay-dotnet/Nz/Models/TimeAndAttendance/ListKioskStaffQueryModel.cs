using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.TimeAndAttendance
{
    public class ListKioskStaffQueryModel
    {
        public bool RestrictCurrentShiftsToCurrentKioskLocation { get; set; }
    }
}
