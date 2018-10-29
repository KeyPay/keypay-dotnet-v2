namespace KeyPay.ApiFunctions.V2
{
    public class ManagerFunction : BaseFunction
    {
        public ManagerFunction(ApiRequestExecutor api) : base(api)
        {
            LeaveRequests = new ManagerLeaveRequestsFunction(api);
            Kiosk = new ManagerKioskFunction(api);
            TimeAndAttendance = new ManagerTimeAndAttendanceFunction(api);
        }

        public ManagerLeaveRequestsFunction LeaveRequests { get; set; }
        public ManagerKioskFunction Kiosk { get; set; }
        public ManagerTimeAndAttendanceFunction TimeAndAttendance { get; set; }
    }
}