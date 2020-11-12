using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Business
{
    public class LocationAccessModel
    {
        public LocationRestrictionFilterTypeEnum FilterType { get; set; }
        public List<Int32> LocationIds { get; set; }
        public UserPermission Permissions { get; set; }
    }
}
