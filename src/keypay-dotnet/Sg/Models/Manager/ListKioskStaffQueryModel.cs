using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Manager
{
    public class ListKioskStaffQueryModel
    {
        public bool RestrictCurrentShiftsToCurrentKioskLocation { get; set; }
    }
}
