using KeyPayV2.Common;
using KeyPayV2.Common.Auth;
using KeyPayV2.Au.Functions;

namespace KeyPayV2.Au
{
    public interface IAuApiClient : IBaseApiClient
    {
        IAuthenticationFunction Authentication { get; }
        IBrandFunction Brand { get; }
        IBusinessFunction Business { get; }
        IChartOfAccountsFunction ChartOfAccounts { get; }
        IContractorFunction Contractor { get; }
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
        IPayCategoryFunction PayCategory { get; }
        IPaymentSummaryFunction PaymentSummary { get; }
        IPayScheduleFunction PaySchedule { get; }
        IPublicHolidayFunction PublicHoliday { get; }
        IQualificationsFunction Qualifications { get; }
        IReportingFunction Reporting { get; }
        IResellerFunction Reseller { get; }
        IRosterShiftFunction RosterShift { get; }
        ITimeAndAttendanceFunction TimeAndAttendance { get; }
        IWebhookFunction Webhook { get; }
        IWhiteLabelFunction WhiteLabel { get; }
        IPayRunFunction PayRun { get; }
        IAbaSettingsFunction AbaSettings { get; }
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
        IEmployeeSelfManagedSuperFundFunction EmployeeSelfManagedSuperFund { get; }
        IEmployeeSuperFundFunction EmployeeSuperFund { get; }
        IEmploymentAgreementFunction EmploymentAgreement { get; }
        IEmployeeOnboardingFunction EmployeeOnboarding { get; }
        ILookupDataFunction LookupData { get; }
        IManagerFunction Manager { get; }
        IPayRateTemplateFunction PayRateTemplate { get; }
        ISuperFundFunction SuperFund { get; }
        ITimesheetsFunction Timesheets { get; }
        IUnavailabilityFunction Unavailability { get; }
        IWorkTypeFunction WorkType { get; }
        IEssFunction Ess { get; }
        IUserFunction User { get; }
    }
    public class AuApiClient : BaseApiClient, IAuApiClient
    {
        public AuApiClient(string baseUrl, AuthenticationDetails authenticationDetails, string userAgent = null) : base(baseUrl, authenticationDetails, userAgent)
        {
            Authentication = new AuthenticationFunction(Api);
            Brand = new BrandFunction(Api);
            Business = new BusinessFunction(Api);
            ChartOfAccounts = new ChartOfAccountsFunction(Api);
            Contractor = new ContractorFunction(Api);
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
            PayCategory = new PayCategoryFunction(Api);
            PaymentSummary = new PaymentSummaryFunction(Api);
            PaySchedule = new PayScheduleFunction(Api);
            PublicHoliday = new PublicHolidayFunction(Api);
            Qualifications = new QualificationsFunction(Api);
            Reporting = new ReportingFunction(Api);
            Reseller = new ResellerFunction(Api);
            RosterShift = new RosterShiftFunction(Api);
            TimeAndAttendance = new TimeAndAttendanceFunction(Api);
            Webhook = new WebhookFunction(Api);
            WhiteLabel = new WhiteLabelFunction(Api);
            PayRun = new PayRunFunction(Api);
            AbaSettings = new AbaSettingsFunction(Api);
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
            EmployeeSelfManagedSuperFund = new EmployeeSelfManagedSuperFundFunction(Api);
            EmployeeSuperFund = new EmployeeSuperFundFunction(Api);
            EmploymentAgreement = new EmploymentAgreementFunction(Api);
            EmployeeOnboarding = new EmployeeOnboardingFunction(Api);
            LookupData = new LookupDataFunction(Api);
            Manager = new ManagerFunction(Api);
            PayRateTemplate = new PayRateTemplateFunction(Api);
            SuperFund = new SuperFundFunction(Api);
            Timesheets = new TimesheetsFunction(Api);
            Unavailability = new UnavailabilityFunction(Api);
            WorkType = new WorkTypeFunction(Api);
            Ess = new EssFunction(Api);
            User = new UserFunction(Api);
        }

        public IAuthenticationFunction Authentication { get; }
        public IBrandFunction Brand { get; }
        public IBusinessFunction Business { get; }
        public IChartOfAccountsFunction ChartOfAccounts { get; }
        public IContractorFunction Contractor { get; }
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
        public IPayCategoryFunction PayCategory { get; }
        public IPaymentSummaryFunction PaymentSummary { get; }
        public IPayScheduleFunction PaySchedule { get; }
        public IPublicHolidayFunction PublicHoliday { get; }
        public IQualificationsFunction Qualifications { get; }
        public IReportingFunction Reporting { get; }
        public IResellerFunction Reseller { get; }
        public IRosterShiftFunction RosterShift { get; }
        public ITimeAndAttendanceFunction TimeAndAttendance { get; }
        public IWebhookFunction Webhook { get; }
        public IWhiteLabelFunction WhiteLabel { get; }
        public IPayRunFunction PayRun { get; }
        public IAbaSettingsFunction AbaSettings { get; }
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
        public IEmployeeSelfManagedSuperFundFunction EmployeeSelfManagedSuperFund { get; }
        public IEmployeeSuperFundFunction EmployeeSuperFund { get; }
        public IEmploymentAgreementFunction EmploymentAgreement { get; }
        public IEmployeeOnboardingFunction EmployeeOnboarding { get; }
        public ILookupDataFunction LookupData { get; }
        public IManagerFunction Manager { get; }
        public IPayRateTemplateFunction PayRateTemplate { get; }
        public ISuperFundFunction SuperFund { get; }
        public ITimesheetsFunction Timesheets { get; }
        public IUnavailabilityFunction Unavailability { get; }
        public IWorkTypeFunction WorkType { get; }
        public IEssFunction Ess { get; }
        public IUserFunction User { get; }
    }
}
