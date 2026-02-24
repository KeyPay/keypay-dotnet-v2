using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Business
{
    public class EmployeeGroupAccessModel
    {
        public int EmployeeGroupId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public UserPermission Permissions { get; set; }
    }
}
