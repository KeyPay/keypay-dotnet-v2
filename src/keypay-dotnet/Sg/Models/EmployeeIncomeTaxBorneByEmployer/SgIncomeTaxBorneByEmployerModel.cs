using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.EmployeeIncomeTaxBorneByEmployer
{
    public class SgIncomeTaxBorneByEmployerModel
    {
        public int Id { get; set; }
        public int BasisPeriod { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public TaxBorneByEmployerType TaxBorneByEmployerType { get; set; }
        public decimal? BorneByEmployerAmount { get; set; }
        public decimal? BorneByEmployeeAmount { get; set; }
    }
}
