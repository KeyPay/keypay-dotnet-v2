using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Common
{
    public class EssWorkTypeModel
    {
        public bool IsUnitBasedWorkType { get; set; }
        public string UnitType { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int? PayCategoryId { get; set; }
        public int? LeaveCategoryId { get; set; }
        public string ExternalId { get; set; }
        public string Source { get; set; }
        public bool AccruesLeave { get; set; }
        public IList<EmploymentTypeEnum> EmploymentTypes { get; set; }
        public WorkTypeMappingType? MappingType { get; set; }
        public string ShortCode { get; set; }
        public int? AwardPackageId { get; set; }
        public string AwardPackageName { get; set; }
    }
}
