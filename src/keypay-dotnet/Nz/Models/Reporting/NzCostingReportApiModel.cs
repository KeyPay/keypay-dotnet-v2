using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Reporting
{
    public class NzCostingReportApiModel
    {
        public decimal KiwiSaverEmployeeContribution { get; set; }
        public decimal KiwiSaverEmployerContribution { get; set; }
        public decimal EsctContribution { get; set; }
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public IDictionary<String,Decimal> PayCategories { get; set; }
    }
}
