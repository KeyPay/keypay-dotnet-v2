using KeyPayV2.Common;
using KeyPayV2.Common.Auth;
using KeyPayV2.Nz.Functions;

namespace KeyPayV2.Nz
{
    public interface INzApiClient : IBaseApiClient
    {
        IBrandFunction Brand { get; }
        IOtherFunction Other { get; }
        IPayRunFunction PayRun { get; }
        IReportingFunction Reporting { get; }
        IWhiteLabelFunction WhiteLabel { get; }
        IInvoicesFunction Invoices { get; }
        IBusinessFunction Business { get; }
        IChartOfAccountsFunction ChartOfAccounts { get; }
        IDeductionCategoriesFunction DeductionCategories { get; }
        IReportingDimensionsFunction ReportingDimensions { get; }
        IEmployeeFunction Employee { get; }
        IEmployeeAccessFunction EmployeeAccess { get; }
        IEmployeeRecurringTransactionsFunction EmployeeRecurringTransactions { get; }
        IEmployeeBankAccountFunction EmployeeBankAccount { get; }
        IEmployeeDocumentFunction EmployeeDocument { get; }
        IEmployeeEarningsLineSplitFunction EmployeeEarningsLineSplit { get; }
        IEmployeeReportingDimensionEarningsLineSplitFunction EmployeeReportingDimensionEarningsLineSplit { get; }
        IEmployeeExpenseRequestFunction EmployeeExpenseRequest { get; }
        IEmployeeLeaveAllowancesFunction EmployeeLeaveAllowances { get; }
        ILeaveAllowanceFunction LeaveAllowance { get; }
        ILeaveRequestsFunction LeaveRequests { get; }
        ILocationFunction Location { get; }
        IEmployeePayRateScheduleFunction EmployeePayRateSchedule { get; }
        IEmployeeQualificationsFunction EmployeeQualifications { get; }
        IAuthenticationFunction Authentication { get; }
        IEmploymentAgreementFunction EmploymentAgreement { get; }
        IEmployeeExpenseCategoriesFunction EmployeeExpenseCategories { get; }
        IEmployeeGroupsFunction EmployeeGroups { get; }
        IEmployeeOnboardingFunction EmployeeOnboarding { get; }
        IEmployerLiabilityCategoriesFunction EmployerLiabilityCategories { get; }
        IEmployingEntitiesFunction EmployingEntities { get; }
        ILeaveCategoriesFunction LeaveCategories { get; }
        ITimeAndAttendanceFunction TimeAndAttendance { get; }
        ILookupDataFunction LookupData { get; }
        IManagerFunction Manager { get; }
        IPayCategoryFunction PayCategory { get; }
        IPayRateTemplateFunction PayRateTemplate { get; }
        IPayScheduleFunction PaySchedule { get; }
        IPublicHolidayFunction PublicHoliday { get; }
        IQualificationsFunction Qualifications { get; }
        IRosterShiftFunction RosterShift { get; }
        ITimesheetsFunction Timesheets { get; }
        IUnavailabilityFunction Unavailability { get; }
        IWebhookFunction Webhook { get; }
        IWorkTypeFunction WorkType { get; }
        IEssFunction Ess { get; }
        IResellerFunction Reseller { get; }
        IUserFunction User { get; }
    }
    public class NzApiClient : BaseApiClient, INzApiClient
    {
        public NzApiClient(string baseUrl, AuthenticationDetails authenticationDetails, string userAgent = null) : base(baseUrl, authenticationDetails, userAgent)
        {
            Brand = new BrandFunction(Api);
            Other = new OtherFunction(Api);
            PayRun = new PayRunFunction(Api);
            Reporting = new ReportingFunction(Api);
            WhiteLabel = new WhiteLabelFunction(Api);
            Invoices = new InvoicesFunction(Api);
            Business = new BusinessFunction(Api);
            ChartOfAccounts = new ChartOfAccountsFunction(Api);
            DeductionCategories = new DeductionCategoriesFunction(Api);
            ReportingDimensions = new ReportingDimensionsFunction(Api);
            Employee = new EmployeeFunction(Api);
            EmployeeAccess = new EmployeeAccessFunction(Api);
            EmployeeRecurringTransactions = new EmployeeRecurringTransactionsFunction(Api);
            EmployeeBankAccount = new EmployeeBankAccountFunction(Api);
            EmployeeDocument = new EmployeeDocumentFunction(Api);
            EmployeeEarningsLineSplit = new EmployeeEarningsLineSplitFunction(Api);
            EmployeeReportingDimensionEarningsLineSplit = new EmployeeReportingDimensionEarningsLineSplitFunction(Api);
            EmployeeExpenseRequest = new EmployeeExpenseRequestFunction(Api);
            EmployeeLeaveAllowances = new EmployeeLeaveAllowancesFunction(Api);
            LeaveAllowance = new LeaveAllowanceFunction(Api);
            LeaveRequests = new LeaveRequestsFunction(Api);
            Location = new LocationFunction(Api);
            EmployeePayRateSchedule = new EmployeePayRateScheduleFunction(Api);
            EmployeeQualifications = new EmployeeQualificationsFunction(Api);
            Authentication = new AuthenticationFunction(Api);
            EmploymentAgreement = new EmploymentAgreementFunction(Api);
            EmployeeExpenseCategories = new EmployeeExpenseCategoriesFunction(Api);
            EmployeeGroups = new EmployeeGroupsFunction(Api);
            EmployeeOnboarding = new EmployeeOnboardingFunction(Api);
            EmployerLiabilityCategories = new EmployerLiabilityCategoriesFunction(Api);
            EmployingEntities = new EmployingEntitiesFunction(Api);
            LeaveCategories = new LeaveCategoriesFunction(Api);
            TimeAndAttendance = new TimeAndAttendanceFunction(Api);
            LookupData = new LookupDataFunction(Api);
            Manager = new ManagerFunction(Api);
            PayCategory = new PayCategoryFunction(Api);
            PayRateTemplate = new PayRateTemplateFunction(Api);
            PaySchedule = new PayScheduleFunction(Api);
            PublicHoliday = new PublicHolidayFunction(Api);
            Qualifications = new QualificationsFunction(Api);
            RosterShift = new RosterShiftFunction(Api);
            Timesheets = new TimesheetsFunction(Api);
            Unavailability = new UnavailabilityFunction(Api);
            Webhook = new WebhookFunction(Api);
            WorkType = new WorkTypeFunction(Api);
            Ess = new EssFunction(Api);
            Reseller = new ResellerFunction(Api);
            User = new UserFunction(Api);
        }

        public IBrandFunction Brand { get; }
        public IOtherFunction Other { get; }
        public IPayRunFunction PayRun { get; }
        public IReportingFunction Reporting { get; }
        public IWhiteLabelFunction WhiteLabel { get; }
        public IInvoicesFunction Invoices { get; }
        public IBusinessFunction Business { get; }
        public IChartOfAccountsFunction ChartOfAccounts { get; }
        public IDeductionCategoriesFunction DeductionCategories { get; }
        public IReportingDimensionsFunction ReportingDimensions { get; }
        public IEmployeeFunction Employee { get; }
        public IEmployeeAccessFunction EmployeeAccess { get; }
        public IEmployeeRecurringTransactionsFunction EmployeeRecurringTransactions { get; }
        public IEmployeeBankAccountFunction EmployeeBankAccount { get; }
        public IEmployeeDocumentFunction EmployeeDocument { get; }
        public IEmployeeEarningsLineSplitFunction EmployeeEarningsLineSplit { get; }
        public IEmployeeReportingDimensionEarningsLineSplitFunction EmployeeReportingDimensionEarningsLineSplit { get; }
        public IEmployeeExpenseRequestFunction EmployeeExpenseRequest { get; }
        public IEmployeeLeaveAllowancesFunction EmployeeLeaveAllowances { get; }
        public ILeaveAllowanceFunction LeaveAllowance { get; }
        public ILeaveRequestsFunction LeaveRequests { get; }
        public ILocationFunction Location { get; }
        public IEmployeePayRateScheduleFunction EmployeePayRateSchedule { get; }
        public IEmployeeQualificationsFunction EmployeeQualifications { get; }
        public IAuthenticationFunction Authentication { get; }
        public IEmploymentAgreementFunction EmploymentAgreement { get; }
        public IEmployeeExpenseCategoriesFunction EmployeeExpenseCategories { get; }
        public IEmployeeGroupsFunction EmployeeGroups { get; }
        public IEmployeeOnboardingFunction EmployeeOnboarding { get; }
        public IEmployerLiabilityCategoriesFunction EmployerLiabilityCategories { get; }
        public IEmployingEntitiesFunction EmployingEntities { get; }
        public ILeaveCategoriesFunction LeaveCategories { get; }
        public ITimeAndAttendanceFunction TimeAndAttendance { get; }
        public ILookupDataFunction LookupData { get; }
        public IManagerFunction Manager { get; }
        public IPayCategoryFunction PayCategory { get; }
        public IPayRateTemplateFunction PayRateTemplate { get; }
        public IPayScheduleFunction PaySchedule { get; }
        public IPublicHolidayFunction PublicHoliday { get; }
        public IQualificationsFunction Qualifications { get; }
        public IRosterShiftFunction RosterShift { get; }
        public ITimesheetsFunction Timesheets { get; }
        public IUnavailabilityFunction Unavailability { get; }
        public IWebhookFunction Webhook { get; }
        public IWorkTypeFunction WorkType { get; }
        public IEssFunction Ess { get; }
        public IResellerFunction Reseller { get; }
        public IUserFunction User { get; }
    }
}
