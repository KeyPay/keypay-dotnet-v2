using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Ess
{
    public class EssWorkTypeModel
    {
        public bool IsUnitBasedWorkType { get; set; }
        public string UnitType { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int? PayCategoryId { get; set; }
        public string PayCategoryName { get; set; }
        public int? LeaveCategoryId { get; set; }
        public string ExternalId { get; set; }
        public string Source { get; set; }
        public bool AccruesLeave { get; set; }
        public IList<EmploymentTypeEnum> EmploymentTypes { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public WorkTypeMappingType? MappingType { get; set; }
        public string ShortCode { get; set; }
        public int? AwardPackageId { get; set; }
        public string AwardPackageName { get; set; }
    }
}
