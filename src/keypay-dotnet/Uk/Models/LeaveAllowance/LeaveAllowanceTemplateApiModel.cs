using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.LeaveAllowance
{
    public class LeaveAllowanceTemplateApiModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<LeaveAllowanceTemplateLeaveCategoryApiModel> LeaveCategories { get; set; }
        public string ExternalId { get; set; }
        public ExternalService Source { get; set; }
    }
}
