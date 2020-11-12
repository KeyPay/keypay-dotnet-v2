using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.LeaveAllowance
{
    public class SgLeaveAllowanceTemplateModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ExternalId { get; set; }
        public ExternalService Source { get; set; }
        public IList<SgLeaveAllowanceTemplateLeaveCategoryApiModel> LeaveCategories { get; set; }
    }
}
