using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.EmploymentAgreement
{
    public class LeaveAllowanceTemplateModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<LeaveAllowanceTemplateLeaveCategoryModel> LeaveCategories { get; set; }
        public string ExternalId { get; set; }
        public ExternalService Source { get; set; }
    }
}
