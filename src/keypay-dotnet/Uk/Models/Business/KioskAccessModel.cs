using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Business
{
    public class KioskAccessModel
    {
        public List<Int32> Kiosks { get; set; }
        public KioskAccessType AccessType { get; set; }
        public UserPermission Permissions { get; set; }
    }
}
