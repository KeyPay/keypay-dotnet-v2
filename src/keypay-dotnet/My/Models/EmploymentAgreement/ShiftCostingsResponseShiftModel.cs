using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.EmploymentAgreement
{
    public class ShiftCostingsResponseShiftModel
    {
        public string ExternalId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal Cost { get; set; }
        public IList<RuleEvaluationResult> EvaluationResults { get; set; }
        public List<String> ConsolidatedShifts { get; set; }
        public List<ShiftCostingBreakdownModel> CostBreakdown { get; set; }
    }
}
