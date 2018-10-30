using System.Collections.Generic;
using KeyPay.Enums;
using KeyPay.DomainModels.V2.Business;

namespace KeyPay.DomainModels.V2.Manager
{
    public class ManagerTimesheetReferenceDataModel
    {
        public List<WorkTypeModel> WorkTypes { get; set; }
        public List<WorkTypeModel> ShiftConditions { get; set; }
        public List<LocationModel> Locations { get; set; }
        public IList<KeyValuePair<int, string>> Classifications { get; set; }
    }

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
        public bool IsUnitBasedWorkType { get; set; }
        public string UnitType { get; set; }
    }
}
