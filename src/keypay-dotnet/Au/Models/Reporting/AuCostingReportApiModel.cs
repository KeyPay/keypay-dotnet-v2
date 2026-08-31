using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Reporting
{
    public class AuCostingReportApiModel
    {
        public decimal SuperContribution { get; set; }
        public decimal EmployerContribution { get; set; }
        public decimal NonRescEmployerContribution { get; set; }
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public IDictionary<String,Decimal> PayCategories { get; set; }
    }
}
