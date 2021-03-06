using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.EmployeeGroups
{
    public class AuDetailedEmployeeGroupModel
    {
        public IList<MatchingEmployeeModel> MatchingEmployees { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public FilterCombinationStrategyEnum FilterCombinationStrategy { get; set; }
        public IList<AuEmployeeFilterModel> Filters { get; set; }
    }
}
