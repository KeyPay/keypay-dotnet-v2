using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Location
{
    public class SgSingleLocationModel
    {
        public List<SgLocationModel> NestedLocations { get; set; }
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public string ExternalId { get; set; }
        public string ExternalAccountingLocationId { get; set; }
        public string Source { get; set; }
        public string FullyQualifiedName { get; set; }
        public bool IsGlobal { get; set; }
        public bool IsRollupReportingLocation { get; set; }
        public string GeneralLedgerMappingCode { get; set; }
        public IList<Int32> DefaultShiftConditionIds { get; set; }
        public string State { get; set; }
    }
}
