using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;
using MidpointRounding = KeyPayV2.Nz.Enums.MidpointRounding;

namespace KeyPayV2.Nz.Models.Common
{
    public class CheckKioskPinModel
    {
        public int? EmployeeId { get; set; }
        public string Pin { get; set; }
    }
}
