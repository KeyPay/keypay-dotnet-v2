using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Business
{
    public class BusinessAccessModel
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public RelatedUserType AccessType { get; set; }
        public IList<EmployeeGroupAccessModel> EmployeeGroups { get; set; }
        public IList<LocationAccessModel> LocationAccess { get; set; }
        public ReportAccessModel Reports { get; set; }
        public KioskAccessModel KioskAccess { get; set; }
        public PayrollAccessModel PayrollAccess { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
