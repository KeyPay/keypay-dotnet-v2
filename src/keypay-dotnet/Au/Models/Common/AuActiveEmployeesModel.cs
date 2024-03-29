using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Common
{
    public class AuActiveEmployeesModel
    {
        public string Abn { get; set; }
        public bool IsStpEnabled { get; set; }
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
