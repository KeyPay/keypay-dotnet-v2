using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.Manager
{
    public class UnitlessLeaveEstimateModel
    {
        public int EmployeeId { get; set; }
        public decimal? Hours { get; set; }
        public List<string> Details { get; set; }
    }

    public class LeaveEstimateModel : UnitlessLeaveEstimateModel
    {
        public decimal? Hours { get; set; }
    }

    public class LeaveEstimateUnitModel : UnitlessLeaveEstimateModel
    {
        public decimal? Units { get; set; }
    }
}