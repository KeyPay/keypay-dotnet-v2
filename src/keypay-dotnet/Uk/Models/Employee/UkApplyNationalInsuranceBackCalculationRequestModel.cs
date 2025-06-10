using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class UkApplyNationalInsuranceBackCalculationRequestModel
    {
        public int PayRunTotalId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public NationalInsuranceType NewCategory { get; set; }
    }
}
