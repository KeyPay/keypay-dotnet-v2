using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.Employee
{
    public class StandardHoursModel
    {
        public StandardHoursModel()
        {
            StandardWorkDays = new List<StandardHoursDayModel>();
        }
        public int EmployeeId { get; set; }
        public decimal StandardHoursPerWeek { get; set; }
        public bool UseAdvancedWorkWeek { get; set; }
        public List<StandardHoursDayModel> StandardWorkDays { get; set; }
    }

    public class StandardHoursDayModel
    {
        public int Id { get; set; }
        public int Week { get; set; }
        public int DayOfWeek { get; set; }
        public string DayName { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string BreakStartTime { get; set; }
        public string BreakEndTime { get; set; }
        public int? LocationId { get; set; }
        public int? WorkTypeId { get; set; }
        public decimal Hours { get; set; }
    }
}