using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.Business
{
    public class LocationAccessModel
    {
        public LocationRestrictionFilterTypeEnum FilterType { get; set; }
        public List<Int32> LocationIds { get; set; }
        public UserPermission Permissions { get; set; }
    }
}
