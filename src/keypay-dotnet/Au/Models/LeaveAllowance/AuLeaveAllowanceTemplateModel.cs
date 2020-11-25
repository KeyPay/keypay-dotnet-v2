using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;
using MidpointRounding = KeyPayV2.Au.Enums.MidpointRounding;

namespace KeyPayV2.Au.Models.LeaveAllowance
{
    public class AuLeaveAllowanceTemplateModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ExternalId { get; set; }
        public ExternalService Source { get; set; }
        public int? LeaveLoadingCalculatedFromPayCategoryId { get; set; }
        public IList<AuLeaveAllowanceTemplateLeaveCategoryApiModel> LeaveCategories { get; set; }
    }
}
