using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.Manager
{
    public class LeaveEstimateModel
    {
        public int EmployeeId { get; set; }
        public decimal? Hours { get; set; }
        public List<string> Details { get; set; }
    }
}