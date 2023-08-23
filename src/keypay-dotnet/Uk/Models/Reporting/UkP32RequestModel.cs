using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class UkP32RequestModel
    {
        public DateTime TaxMonth { get; set; }
        public decimal AdvanceFunding { get; set; }
        public decimal HmrcPayment { get; set; }
        public decimal NetCISDeductions { get; set; }
    }
}
