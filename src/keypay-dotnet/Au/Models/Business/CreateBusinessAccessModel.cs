using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Business
{
    public class CreateBusinessAccessModel
    {
        public bool SuppressNotificationEmails { get; set; }
        public bool MergeExistingAccess { get; set; }
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
