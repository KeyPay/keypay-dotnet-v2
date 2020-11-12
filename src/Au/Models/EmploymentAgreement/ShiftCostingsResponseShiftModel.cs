using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.EmploymentAgreement
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
