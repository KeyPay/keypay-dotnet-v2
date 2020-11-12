using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Business
{
    public class EntitlementsModel
    {
        public string PlanName { get; set; }
        public DateTime TrialExpiryDate { get; set; }
        public IList<EntitlementFeatureModel> Features { get; set; }
    }
}
