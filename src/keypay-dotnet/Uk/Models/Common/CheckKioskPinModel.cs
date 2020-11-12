using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Common
{
    public class CheckKioskPinModel
    {
        public int? EmployeeId { get; set; }
        public string Pin { get; set; }
    }
}
