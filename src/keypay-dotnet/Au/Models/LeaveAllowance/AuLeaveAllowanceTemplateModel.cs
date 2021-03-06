using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.LeaveAllowance
{
    public class AuLeaveAllowanceTemplateModel
    {
        public int? LeaveLoadingCalculatedFromPayCategoryId { get; set; }
        public IList<AuLeaveAllowanceTemplateLeaveCategoryApiModel> LeaveCategories { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string ExternalId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ExternalService Source { get; set; }
    }
}
