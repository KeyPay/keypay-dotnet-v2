using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.LeaveCategories
{
    public class UkLeaveCategoryUkOccupationalAbsenceServiceBandModel
    {
        public int Id { get; set; }
        public int ServiceLength { get; set; }
        public int From { get; set; }
        public int? To { get; set; }
        public IList<UkLeaveCategoryUkOccupationalAbsenceEntitlementModel> Entitlements { get; set; }
        public bool AddStatutory { get; set; }
    }
}
