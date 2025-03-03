using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class UpdateP32ReportQueryModel
    {
        public int FinancialYearEnding { get; set; }
        public int? PayeSchemeId { get; set; }
    }
}
