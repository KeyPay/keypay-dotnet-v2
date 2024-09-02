using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Business
{
    public class PayrollAccessModel
    {
        public bool ApproveElectronicPayrollLodgement { get; set; }
        public int UserBusinessRestrictionCount { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public BusinessRestrictionTypeEnum? PayRunApprovalAccess { get; set; }
        public Int32[] SelectedPaySchedulesForPayRunApproval { get; set; }
    }
}
