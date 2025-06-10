using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Common
{
    public class MyWorkTypeModel
    {
        public IList<MyEmploymentTypeEnum> EmploymentTypes { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int? PayCategoryId { get; set; }
        public int? LeaveCategoryId { get; set; }
        public string ExternalId { get; set; }
        public string Source { get; set; }
        public bool AccruesLeave { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public WorkTypeMappingType? MappingType { get; set; }
        public string ShortCode { get; set; }
    }
}
