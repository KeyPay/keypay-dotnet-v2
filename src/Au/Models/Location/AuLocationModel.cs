using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Location
{
    public class AuLocationModel
    {
        public string State { get; set; }
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public string ExternalId { get; set; }
        public string Source { get; set; }
        public string FullyQualifiedName { get; set; }
        public bool IsGlobal { get; set; }
        public bool IsRollupReportingLocation { get; set; }
        public string GeneralLedgerMappingCode { get; set; }
        public IList<Int32> DefaultShiftConditionIds { get; set; }
    }
}
