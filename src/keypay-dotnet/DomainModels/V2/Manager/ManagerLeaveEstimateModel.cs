namespace KeyPay.DomainModels.V2.Manager
{
    public class ManagerLeaveEstimateModel
    {
        public decimal? LeaveBalance { get; set; }
        public decimal? ApprovedLeave { get; set; }
        public decimal? AvailableBalance { get; set; }
        public LeaveEstimateModel LeaveRequired { get; set; }
    }
}