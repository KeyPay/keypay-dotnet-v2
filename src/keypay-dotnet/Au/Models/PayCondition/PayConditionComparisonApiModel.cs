using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.PayCondition
{
    public class PayConditionComparisonApiModel
    {
        public int Id { get; set; }
        public int AwardPackageId { get; set; }
        public IdAndName BusinessAwardPackage { get; set; }
        public IdAndName EmploymentAgreement { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ComparisonStartDateType ComparisonStartDateType { get; set; }
        public DateTime? ComparisonStartDate { get; set; }
        public List<AwardTagDto> Tags { get; set; }
    }
}
