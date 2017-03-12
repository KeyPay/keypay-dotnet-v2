using System.Collections.Generic;
using KeyPay.Enums;

namespace KeyPay.DomainModels.V2.Business
{
    public class WorkTypeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? PayCategoryId { get; set; }
        public int? LeaveCategoryId { get; set; }
        public string ExternalId { get; set; }
        public string Source { get; set; }
        public bool AccruesLeave { get; set; }
        public IList<EmploymentType> EmploymentTypes { get; set; }
        public WorkTypeMappingType? MappingType { get; set; }
        public string ShortCode { get; set; }
    }
}