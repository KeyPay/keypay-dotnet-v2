using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.PayConditionComparison
{
    public class CreatePayConditionComparisonRequest
    {
        public int AwardPackageId { get; set; }
        public int EmploymentAgreementId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ComparisonStartDateType? ComparisonStartDateType { get; set; }
        public DateTime? ComparisonStartDate { get; set; }
        public List<Int32> TagIds { get; set; }
    }
}
