using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Common
{
    public class CommonActiveEmployeesModel
    {
        public int BusinessId { get; set; }
        public string BusinessName { get; set; }
        public DateTime DateCreated { get; set; }
        public string BillingPlan { get; set; }
        public string RealmId { get; set; }
        public string ExternalId { get; set; }
        public string EmailAddresses { get; set; }
        public string UserIds { get; set; }
        public int NumberOfIncompleteEmployees { get; set; }
        public int NumberOfCompleteEmployees { get; set; }
        public int NumberOfEmployeesPaid { get; set; }
        public int NumberOfPayRuns { get; set; }
        public DateTime? DateLastPayRunFinalised { get; set; }
        public DateTime? DateLastBillableActivity { get; set; }
        public int ActiveEmps { get; set; }
    }
}
