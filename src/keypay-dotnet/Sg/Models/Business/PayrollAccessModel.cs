using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Business
{
    public class PayrollAccessModel
    {
        public bool ApproveElectronicPayrollLodgement { get; set; }
        public int UserBusinessRestrictionCount { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public BusinessRestrictionTypeEnum? PayRunApprovalAccess { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public BusinessRestrictionTypeEnum? PayRunCreationAccess { get; set; }
        public Int32[] SelectedPaySchedulesForPayRunApproval { get; set; }
        public Int32[] SelectedPaySchedulesForPayRunCreation { get; set; }
    }
}
