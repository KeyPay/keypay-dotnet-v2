using KeyPayV2.Common;
using KeyPayV2.Common.Auth;
using KeyPayV2.My.Functions;

namespace KeyPayV2.My
{
    public interface IMyApiClient : IBaseApiClient
    {
        IBrandFunction Brand { get; }
        IBusinessFunction Business { get; }
        IChartOfAccountsFunction ChartOfAccounts { get; }
        IDeductionCategoriesFunction DeductionCategories { get; }
        IEmployeeFunction Employee { get; }
        IEmployeeExpenseCategoriesFunction EmployeeExpenseCategories { get; }
        IEmployeeGroupsFunction EmployeeGroups { get; }
        IEmployerLiabilityCategoriesFunction EmployerLiabilityCategories { get; }
        IEmployingEntitiesFunction EmployingEntities { get; }
        IInvoicesFunction Invoices { get; }
        ILeaveAllowanceFunction LeaveAllowance { get; }
        ILeaveCategoriesFunction LeaveCategories { get; }
        ILocationFunction Location { get; }
        IOtherFunction Other { get; }
        IPayRunFunction PayRun { get; }
        IPublicHolidayFunction PublicHoliday { get; }
        IQualificationsFunction Qualifications { get; }
        IReportingFunction Reporting { get; }
        ITieredLeaveAllowanceFunction TieredLeaveAllowance { get; }
        ITimeAndAttendanceFunction TimeAndAttendance { get; }
        IWebhookFunction Webhook { get; }
        IWhiteLabelFunction WhiteLabel { get; }
        IReportingDimensionsFunction ReportingDimensions { get; }
        IEmployeeAccessFunction EmployeeAccess { get; }
        IEmployeeRecurringTransactionsFunction EmployeeRecurringTransactions { get; }
        IEmployeeBankAccountFunction EmployeeBankAccount { get; }
        IEmployeeDocumentFunction EmployeeDocument { get; }
        IEmployeeEarningsLineSplitFunction EmployeeEarningsLineSplit { get; }
        IEmployeeReportingDimensionEarningsLineSplitFunction EmployeeReportingDimensionEarningsLineSplit { get; }
        IEmployeeExpenseRequestFunction EmployeeExpenseRequest { get; }
        IEmployeeLeaveAllowancesFunction EmployeeLeaveAllowances { get; }
        ILeaveRequestsFunction LeaveRequests { get; }
        IEmployeePayRateScheduleFunction EmployeePayRateSchedule { get; }
        IEmployeeQualificationsFunction EmployeeQualifications { get; }
        IAuthenticationFunction Authentication { get; }
        IEmploymentAgreementFunction EmploymentAgreement { get; }
        IEmployeeOnboardingFunction EmployeeOnboarding { get; }
        ILookupDataFunction LookupData { get; }
        IManagerFunction Manager { get; }
        IPayCategoryFunction PayCategory { get; }
        IPayRateTemplateFunction PayRateTemplate { get; }
        IPayScheduleFunction PaySchedule { get; }
        IRosterShiftFunction RosterShift { get; }
        ITimesheetsFunction Timesheets { get; }
        IUnavailabilityFunction Unavailability { get; }
        IWorkTypeFunction WorkType { get; }
        IEssFunction Ess { get; }
        IResellerFunction Reseller { get; }
        IUserFunction User { get; }
    }
    public class MyApiClient : BaseApiClient, IMyApiClient
    {
        public MyApiClient(string baseUrl, AuthenticationDetails authenticationDetails, string userAgent = null) : base(baseUrl, authenticationDetails, userAgent)
        {
            Brand = new BrandFunction(Api);
            Business = new BusinessFunction(Api);
            ChartOfAccounts = new ChartOfAccountsFunction(Api);
            DeductionCategories = new DeductionCategoriesFunction(Api);
            Employee = new EmployeeFunction(Api);
            EmployeeExpenseCategories = new EmployeeExpenseCategoriesFunction(Api);
            EmployeeGroups = new EmployeeGroupsFunction(Api);
            EmployerLiabilityCategories = new EmployerLiabilityCategoriesFunction(Api);
            EmployingEntities = new EmployingEntitiesFunction(Api);
            Invoices = new InvoicesFunction(Api);
            LeaveAllowance = new LeaveAllowanceFunction(Api);
            LeaveCategories = new LeaveCategoriesFunction(Api);
            Location = new LocationFunction(Api);
            Other = new OtherFunction(Api);
            PayRun = new PayRunFunction(Api);
            PublicHoliday = new PublicHolidayFunction(Api);
            Qualifications = new QualificationsFunction(Api);
            Reporting = new ReportingFunction(Api);
            TieredLeaveAllowance = new TieredLeaveAllowanceFunction(Api);
            TimeAndAttendance = new TimeAndAttendanceFunction(Api);
            Webhook = new WebhookFunction(Api);
            WhiteLabel = new WhiteLabelFunction(Api);
            ReportingDimensions = new ReportingDimensionsFunction(Api);
            EmployeeAccess = new EmployeeAccessFunction(Api);
            EmployeeRecurringTransactions = new EmployeeRecurringTransactionsFunction(Api);
            EmployeeBankAccount = new EmployeeBankAccountFunction(Api);
            EmployeeDocument = new EmployeeDocumentFunction(Api);
            EmployeeEarningsLineSplit = new EmployeeEarningsLineSplitFunction(Api);
            EmployeeReportingDimensionEarningsLineSplit = new EmployeeReportingDimensionEarningsLineSplitFunction(Api);
            EmployeeExpenseRequest = new EmployeeExpenseRequestFunction(Api);
            EmployeeLeaveAllowances = new EmployeeLeaveAllowancesFunction(Api);
            LeaveRequests = new LeaveRequestsFunction(Api);
            EmployeePayRateSchedule = new EmployeePayRateScheduleFunction(Api);
            EmployeeQualifications = new EmployeeQualificationsFunction(Api);
            Authentication = new AuthenticationFunction(Api);
            EmploymentAgreement = new EmploymentAgreementFunction(Api);
            EmployeeOnboarding = new EmployeeOnboardingFunction(Api);
            LookupData = new LookupDataFunction(Api);
            Manager = new ManagerFunction(Api);
            PayCategory = new PayCategoryFunction(Api);
            PayRateTemplate = new PayRateTemplateFunction(Api);
            PaySchedule = new PayScheduleFunction(Api);
            RosterShift = new RosterShiftFunction(Api);
            Timesheets = new TimesheetsFunction(Api);
            Unavailability = new UnavailabilityFunction(Api);
            WorkType = new WorkTypeFunction(Api);
            Ess = new EssFunction(Api);
            Reseller = new ResellerFunction(Api);
            User = new UserFunction(Api);
        }

        public IBrandFunction Brand { get; }
        public IBusinessFunction Business { get; }
        public IChartOfAccountsFunction ChartOfAccounts { get; }
        public IDeductionCategoriesFunction DeductionCategories { get; }
        public IEmployeeFunction Employee { get; }
        public IEmployeeExpenseCategoriesFunction EmployeeExpenseCategories { get; }
        public IEmployeeGroupsFunction EmployeeGroups { get; }
        public IEmployerLiabilityCategoriesFunction EmployerLiabilityCategories { get; }
        public IEmployingEntitiesFunction EmployingEntities { get; }
        public IInvoicesFunction Invoices { get; }
        public ILeaveAllowanceFunction LeaveAllowance { get; }
        public ILeaveCategoriesFunction LeaveCategories { get; }
        public ILocationFunction Location { get; }
        public IOtherFunction Other { get; }
        public IPayRunFunction PayRun { get; }
        public IPublicHolidayFunction PublicHoliday { get; }
        public IQualificationsFunction Qualifications { get; }
        public IReportingFunction Reporting { get; }
        public ITieredLeaveAllowanceFunction TieredLeaveAllowance { get; }
        public ITimeAndAttendanceFunction TimeAndAttendance { get; }
        public IWebhookFunction Webhook { get; }
        public IWhiteLabelFunction WhiteLabel { get; }
        public IReportingDimensionsFunction ReportingDimensions { get; }
        public IEmployeeAccessFunction EmployeeAccess { get; }
        public IEmployeeRecurringTransactionsFunction EmployeeRecurringTransactions { get; }
        public IEmployeeBankAccountFunction EmployeeBankAccount { get; }
        public IEmployeeDocumentFunction EmployeeDocument { get; }
        public IEmployeeEarningsLineSplitFunction EmployeeEarningsLineSplit { get; }
        public IEmployeeReportingDimensionEarningsLineSplitFunction EmployeeReportingDimensionEarningsLineSplit { get; }
        public IEmployeeExpenseRequestFunction EmployeeExpenseRequest { get; }
        public IEmployeeLeaveAllowancesFunction EmployeeLeaveAllowances { get; }
        public ILeaveRequestsFunction LeaveRequests { get; }
        public IEmployeePayRateScheduleFunction EmployeePayRateSchedule { get; }
        public IEmployeeQualificationsFunction EmployeeQualifications { get; }
        public IAuthenticationFunction Authentication { get; }
        public IEmploymentAgreementFunction EmploymentAgreement { get; }
        public IEmployeeOnboardingFunction EmployeeOnboarding { get; }
        public ILookupDataFunction LookupData { get; }
        public IManagerFunction Manager { get; }
        public IPayCategoryFunction PayCategory { get; }
        public IPayRateTemplateFunction PayRateTemplate { get; }
        public IPayScheduleFunction PaySchedule { get; }
        public IRosterShiftFunction RosterShift { get; }
        public ITimesheetsFunction Timesheets { get; }
        public IUnavailabilityFunction Unavailability { get; }
        public IWorkTypeFunction WorkType { get; }
        public IEssFunction Ess { get; }
        public IResellerFunction Reseller { get; }
        public IUserFunction User { get; }
    }
}
