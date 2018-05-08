using System;
using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.Business
{
    public class TimesheetModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal Units { get; set; }
        public string WorkTypeId { get; set; }
        public string LocationId { get; set; }
        public string Comments { get; set; }
        public List<TimesheetBreakModel> Breaks { get; set; }
        public string Status { get; set; }
        public decimal? Rate { get; set; }
        public string LeaveCategoryId { get; set; }
        public string PayCategoryId { get; set; }
        public string ClassificationId { get; set; }
        public string ExternalId { get; set; }
        public int? AttachmentId { get; set; }
        public IList<string> ShiftConditionIds { get; set; }
        public string WorkType { get; set; }
        public string FullyQualifiedLocationName { get; set; }
        public string Classification { get; set; }
        public List<string> ShiftConditions { get; set; }
    }
}