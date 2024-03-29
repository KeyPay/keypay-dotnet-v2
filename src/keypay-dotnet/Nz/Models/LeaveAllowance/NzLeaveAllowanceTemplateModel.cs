using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.LeaveAllowance
{
    public class NzLeaveAllowanceTemplateModel
    {
        public IList<NzLeaveAllowanceTemplateLeaveCategoryApiModel> LeaveCategories { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string ExternalId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ExternalService Source { get; set; }
        public DateTime? LeaveYearStart { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveAccrualStartDateType? LeaveAccrualStartDateType { get; set; }
    }
}
