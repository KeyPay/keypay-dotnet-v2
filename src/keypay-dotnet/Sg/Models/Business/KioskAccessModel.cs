using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.Business
{
    public class KioskAccessModel
    {
        public List<Int32> Kiosks { get; set; }
        public KioskAccessType AccessType { get; set; }
        public UserPermission Permissions { get; set; }
    }
}
