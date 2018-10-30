using KeyPay.ApiFunctions.V2;
using KeyPay.Auth;

namespace KeyPay
{
    public class KeyPayApiV2Client
    {
        public KeyPayApiV2Client(string baseUrl, AuthenticationDetails authenticationDetails)
        {
            var api = new ApiRequestExecutor(baseUrl) {Authenticator = authenticationDetails.Authenticator};
            Business = new BusinessFunction(api);
            PayCategory = new PayCategoryFunction(api);
            PaySchedule = new PayScheduleFunction(api);
            Employee = new EmployeeFunction(api);
            Location = new LocationFunction(api);
            PayRun = new PayRunFunction(api);
            LeaveCategory = new LeaveCategoryFunction(api);
            Report = new ReportFunction(api);
            Timesheet = new TimesheetFunction(api);
            User = new UserFunction(api);
            PayRateTemplates = new PayRateTemplateFunction(api);
            DeductionCategory = new DeductionCategoryFunction(api);
            ExpenseCategory = new ExpenseCategoryFunction(api);
            WorkType = new WorkTypeFunction(api);
            Document = new DocumentFunction(api);
            EmployeeGroup = new EmployeeGroupFunction(api);
            EmployingEntity = new EmployingEntityFunction(api);
            PaymentSummary = new PaymentSummaryFunction(api);
            RosterShift = new RosterShiftFunction(api);
            Manager = new ManagerFunction(api);
            Kiosk = new KioskFunction(api);
            TimeAndAttendance = new TimeAndAttendanceFunction(api);
        }

        public UserFunction User { get; }
        public BusinessFunction Business { get; }
        public PayCategoryFunction PayCategory { get; }
        public PayScheduleFunction PaySchedule { get; }
        public EmployeeFunction Employee { get;  }
        public LocationFunction Location { get; }
        public WorkTypeFunction WorkType { get; }
        public PayRunFunction PayRun { get; }
        public LeaveCategoryFunction LeaveCategory { get; }
        public ReportFunction Report { get; }
        public TimesheetFunction Timesheet { get; }
        public PayRateTemplateFunction PayRateTemplates { get; }
        public DeductionCategoryFunction DeductionCategory { get; }
        public ExpenseCategoryFunction ExpenseCategory { get; }
        public EmployeeGroupFunction EmployeeGroup { get; }
        public DocumentFunction Document { get; }
        public EmployingEntityFunction EmployingEntity { get; }
        public PaymentSummaryFunction PaymentSummary { get; }
        public RosterShiftFunction RosterShift { get; }
        public ManagerFunction Manager { get; }
        public KioskFunction Kiosk { get; }
        public TimeAndAttendanceFunction TimeAndAttendance { get; set; }
    }
}