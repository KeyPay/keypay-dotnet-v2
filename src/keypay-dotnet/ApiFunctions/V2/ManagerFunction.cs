namespace KeyPay.ApiFunctions.V2
{
    public class ManagerFunction : BaseFunction
    {
        public ManagerFunction(ApiRequestExecutor api) : base(api)
        {
            LeaveRequests = new ManagerLeaveRequestsFunction(api);
        }

        public ManagerLeaveRequestsFunction LeaveRequests { get; set; }
    }
}