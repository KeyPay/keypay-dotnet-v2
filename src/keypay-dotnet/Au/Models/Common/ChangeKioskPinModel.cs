using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Common
{
    public class ChangeKioskPinModel
    {
        public int? EmployeeId { get; set; }
        public string OldPin { get; set; }
        public string NewPin { get; set; }
    }
}
