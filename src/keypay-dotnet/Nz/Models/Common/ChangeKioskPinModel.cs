using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Common
{
    public class ChangeKioskPinModel
    {
        public int? EmployeeId { get; set; }
        public string OldPin { get; set; }
        public string NewPin { get; set; }
    }
}
