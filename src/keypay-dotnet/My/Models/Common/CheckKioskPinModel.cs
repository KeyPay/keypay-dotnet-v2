using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Common
{
    public class CheckKioskPinModel
    {
        public int? EmployeeId { get; set; }
        public string Pin { get; set; }
    }
}
