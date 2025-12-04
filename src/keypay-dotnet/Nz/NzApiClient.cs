using KeyPayV2.Common;
using KeyPayV2.Common.Auth;
using KeyPayV2.Nz.Functions;

namespace KeyPayV2.Nz
{
    public interface INzApiClient : IBaseApiClient
    {
        IAuthenticationFunction Authentication { get; }
        IBrandFunction Brand { get; }
        IBusinessFunction Business { get; }
        IChartOfAccountsFunction ChartOfAccounts { get; }
        IDeductionCategoriesFunction DeductionCategories { get; }
        IEmployeeFunction Employee { get; }
        IEmployeeExpenseCategoriesFunction EmployeeExpenseCategories { get; }
        IEmployeeGroupsFunction EmployeeGroups { get; }
        IEmployeeOnboardingFunction EmployeeOnboarding { get; }
        IEmployeeRecurringTransactionsFunction EmployeeRecurringTransactions { get; }
        IEmployingEntitiesFunction EmployingEntities { get; }
        ILeaveAllowanceFunction LeaveAllowance { get; }
        ILeaveCategoriesFunction LeaveCategories { get; }
        ILocationFunction Location { get; }
        ILookupDataFunction LookupData { get; }
        IOtherFunction Other { get; }
        IPayCategoryFunction PayCategory { get; }
        IPayScheduleFunction PaySchedule { get; }
        IPublicHolidayFunction PublicHoliday { get; }
        IReportingFunction Reporting { get; }
        IReportingDimensionsFunction ReportingDimensions { get; }
        IResellerFunction Reseller { get; }
        IRosterShiftFunction RosterShift { get; }
        IUserFunction User { get; }
        IWhiteLabelFunction WhiteLabel { get; }
        IWorkTypeFunction WorkType { get; }
        IEmployeeAccessFunction EmployeeAccess { get; }
        IEmployeeBankAccountFunction EmployeeBankAccount { get; }
        IEmployeeDocumentFunction EmployeeDocument { get; }
        IEmployeeEarningsLineSplitFunction EmployeeEarningsLineSplit { get; }
        IEmployeeReportingDimensionEarningsLineSplitFunction EmployeeReportingDimensionEarningsLineSplit { get; }
        IEmployeeExpenseRequestFunction EmployeeExpenseRequest { get; }
        IEmployeeLeaveAllowancesFunction EmployeeLeaveAllowances { get; }
        ILeaveRequestsFunction LeaveRequests { get; }
        IEmployeePayRateScheduleFunction EmployeePayRateSchedule { get; }
        IPayRunFunction PayRun { get; }
        IEmployeeQualificationsFunction EmployeeQualifications { get; }
        IEmploymentAgreementFunction EmploymentAgreement { get; }
        ITimeAndAttendanceFunction TimeAndAttendance { get; }
        IManagerFunction Manager { get; }
        IPayRateTemplateFunction PayRateTemplate { get; }
        ITimesheetsFunction Timesheets { get; }
        IUnavailabilityFunction Unavailability { get; }
        IEssFunction Ess { get; }
    }
    public class NzApiClient : BaseApiClient, INzApiClient
    {
        public NzApiClient(string baseUrl, AuthenticationDetails authenticationDetails, string userAgent = null) : base(baseUrl, authenticationDetails, userAgent)
        {
            Authentication = new AuthenticationFunction(Api);
            Brand = new BrandFunction(Api);
            Business = new BusinessFunction(Api);
            ChartOfAccounts = new ChartOfAccountsFunction(Api);
            DeductionCategories = new DeductionCategoriesFunction(Api);
            Employee = new EmployeeFunction(Api);
            EmployeeExpenseCategories = new EmployeeExpenseCategoriesFunction(Api);
            EmployeeGroups = new EmployeeGroupsFunction(Api);
            EmployeeOnboarding = new EmployeeOnboardingFunction(Api);
            EmployeeRecurringTransactions = new EmployeeRecurringTransactionsFunction(Api);
            EmployingEntities = new EmployingEntitiesFunction(Api);
            LeaveAllowance = new LeaveAllowanceFunction(Api);
            LeaveCategories = new LeaveCategoriesFunction(Api);
            Location = new LocationFunction(Api);
            LookupData = new LookupDataFunction(Api);
            Other = new OtherFunction(Api);
            PayCategory = new PayCategoryFunction(Api);
            PaySchedule = new PayScheduleFunction(Api);
            PublicHoliday = new PublicHolidayFunction(Api);
            Reporting = new ReportingFunction(Api);
            ReportingDimensions = new ReportingDimensionsFunction(Api);
            Reseller = new ResellerFunction(Api);
            RosterShift = new RosterShiftFunction(Api);
            User = new UserFunction(Api);
            WhiteLabel = new WhiteLabelFunction(Api);
            WorkType = new WorkTypeFunction(Api);
            EmployeeAccess = new EmployeeAccessFunction(Api);
            EmployeeBankAccount = new EmployeeBankAccountFunction(Api);
            EmployeeDocument = new EmployeeDocumentFunction(Api);
            EmployeeEarningsLineSplit = new EmployeeEarningsLineSplitFunction(Api);
            EmployeeReportingDimensionEarningsLineSplit = new EmployeeReportingDimensionEarningsLineSplitFunction(Api);
            EmployeeExpenseRequest = new EmployeeExpenseRequestFunction(Api);
            EmployeeLeaveAllowances = new EmployeeLeaveAllowancesFunction(Api);
            LeaveRequests = new LeaveRequestsFunction(Api);
            EmployeePayRateSchedule = new EmployeePayRateScheduleFunction(Api);
            PayRun = new PayRunFunction(Api);
            EmployeeQualifications = new EmployeeQualificationsFunction(Api);
            EmploymentAgreement = new EmploymentAgreementFunction(Api);
            TimeAndAttendance = new TimeAndAttendanceFunction(Api);
            Manager = new ManagerFunction(Api);
            PayRateTemplate = new PayRateTemplateFunction(Api);
            Timesheets = new TimesheetsFunction(Api);
            Unavailability = new UnavailabilityFunction(Api);
            Ess = new EssFunction(Api);
        }

        public IAuthenticationFunction Authentication { get; }
        public IBrandFunction Brand { get; }
        public IBusinessFunction Business { get; }
        public IChartOfAccountsFunction ChartOfAccounts { get; }
        public IDeductionCategoriesFunction DeductionCategories { get; }
        public IEmployeeFunction Employee { get; }
        public IEmployeeExpenseCategoriesFunction EmployeeExpenseCategories { get; }
        public IEmployeeGroupsFunction EmployeeGroups { get; }
        public IEmployeeOnboardingFunction EmployeeOnboarding { get; }
        public IEmployeeRecurringTransactionsFunction EmployeeRecurringTransactions { get; }
        public IEmployingEntitiesFunction EmployingEntities { get; }
        public ILeaveAllowanceFunction LeaveAllowance { get; }
        public ILeaveCategoriesFunction LeaveCategories { get; }
        public ILocationFunction Location { get; }
        public ILookupDataFunction LookupData { get; }
        public IOtherFunction Other { get; }
        public IPayCategoryFunction PayCategory { get; }
        public IPayScheduleFunction PaySchedule { get; }
        public IPublicHolidayFunction PublicHoliday { get; }
        public IReportingFunction Reporting { get; }
        public IReportingDimensionsFunction ReportingDimensions { get; }
        public IResellerFunction Reseller { get; }
        public IRosterShiftFunction RosterShift { get; }
        public IUserFunction User { get; }
        public IWhiteLabelFunction WhiteLabel { get; }
        public IWorkTypeFunction WorkType { get; }
        public IEmployeeAccessFunction EmployeeAccess { get; }
        public IEmployeeBankAccountFunction EmployeeBankAccount { get; }
        public IEmployeeDocumentFunction EmployeeDocument { get; }
        public IEmployeeEarningsLineSplitFunction EmployeeEarningsLineSplit { get; }
        public IEmployeeReportingDimensionEarningsLineSplitFunction EmployeeReportingDimensionEarningsLineSplit { get; }
        public IEmployeeExpenseRequestFunction EmployeeExpenseRequest { get; }
        public IEmployeeLeaveAllowancesFunction EmployeeLeaveAllowances { get; }
        public ILeaveRequestsFunction LeaveRequests { get; }
        public IEmployeePayRateScheduleFunction EmployeePayRateSchedule { get; }
        public IPayRunFunction PayRun { get; }
        public IEmployeeQualificationsFunction EmployeeQualifications { get; }
        public IEmploymentAgreementFunction EmploymentAgreement { get; }
        public ITimeAndAttendanceFunction TimeAndAttendance { get; }
        public IManagerFunction Manager { get; }
        public IPayRateTemplateFunction PayRateTemplate { get; }
        public ITimesheetsFunction Timesheets { get; }
        public IUnavailabilityFunction Unavailability { get; }
        public IEssFunction Ess { get; }
    }
}
