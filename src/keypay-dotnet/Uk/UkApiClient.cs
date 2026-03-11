using KeyPayV2.Common;
using KeyPayV2.Common.Auth;
using KeyPayV2.Uk.Functions;

namespace KeyPayV2.Uk
{
    public interface IUkApiClient : IBaseApiClient
    {
        IAuthenticationFunction Authentication { get; }
        IBenefitCategoryFunction BenefitCategory { get; }
        IBusinessFunction Business { get; }
        IChartOfAccountsFunction ChartOfAccounts { get; }
        IDeductionCategoriesFunction DeductionCategories { get; }
        IEmployeeFunction Employee { get; }
        IEmployeeAccessFunction EmployeeAccess { get; }
        IEmployeeBankAccountFunction EmployeeBankAccount { get; }
        IEmployeeBenefitCategoryFunction EmployeeBenefitCategory { get; }
        IEmployeeDocumentFunction EmployeeDocument { get; }
        IEmployeeEarningsLineSplitFunction EmployeeEarningsLineSplit { get; }
        IEmployeeExpenseCategoriesFunction EmployeeExpenseCategories { get; }
        IEmployeeExpenseRequestFunction EmployeeExpenseRequest { get; }
        IEmployeeGroupsFunction EmployeeGroups { get; }
        IEmployeeLeaveAllowancesFunction EmployeeLeaveAllowances { get; }
        IEmployeeOnboardingFunction EmployeeOnboarding { get; }
        IEmployeePayRateScheduleFunction EmployeePayRateSchedule { get; }
        IEmployeeQualificationsFunction EmployeeQualifications { get; }
        IEmployeeRecurringTransactionsFunction EmployeeRecurringTransactions { get; }
        IEmployeeReportingDimensionEarningsLineSplitFunction EmployeeReportingDimensionEarningsLineSplit { get; }
        IEmployerLiabilityCategoriesFunction EmployerLiabilityCategories { get; }
        IEmploymentAgreementFunction EmploymentAgreement { get; }
        IEssFunction Ess { get; }
        IInvoicesFunction Invoices { get; }
        ILeaveAllowanceFunction LeaveAllowance { get; }
        ILeaveCategoriesFunction LeaveCategories { get; }
        ILeaveRequestsFunction LeaveRequests { get; }
        ILookupDataFunction LookupData { get; }
        IManagerFunction Manager { get; }
        IOtherFunction Other { get; }
        IPayCategoryFunction PayCategory { get; }
        IPayConditionFunction PayCondition { get; }
        IPayeSchemeFunction PayeScheme { get; }
        IPayRateTemplateFunction PayRateTemplate { get; }
        IPayRunFunction PayRun { get; }
        IPayScheduleFunction PaySchedule { get; }
        IPensionSettingsFunction PensionSettings { get; }
        IPublicHolidayFunction PublicHoliday { get; }
        IQualificationsFunction Qualifications { get; }
        IReportingDimensionsFunction ReportingDimensions { get; }
        IRosterShiftFunction RosterShift { get; }
        ISubcontractorFunction Subcontractor { get; }
        ITimeAndAttendanceFunction TimeAndAttendance { get; }
        ITimesheetsFunction Timesheets { get; }
        IUnavailabilityFunction Unavailability { get; }
        IUserFunction User { get; }
        IWebhookFunction Webhook { get; }
        IWorkTypeFunction WorkType { get; }
        IBrandFunction Brand { get; }
        IResellerFunction Reseller { get; }
        IWhiteLabelFunction WhiteLabel { get; }
        IReportingFunction Reporting { get; }
    }
    public class UkApiClient : BaseApiClient, IUkApiClient
    {
        public UkApiClient(string baseUrl, AuthenticationDetails authenticationDetails, string userAgent = null) : base(baseUrl, authenticationDetails, userAgent)
        {
            Authentication = new AuthenticationFunction(Api);
            BenefitCategory = new BenefitCategoryFunction(Api);
            Business = new BusinessFunction(Api);
            ChartOfAccounts = new ChartOfAccountsFunction(Api);
            DeductionCategories = new DeductionCategoriesFunction(Api);
            Employee = new EmployeeFunction(Api);
            EmployeeAccess = new EmployeeAccessFunction(Api);
            EmployeeBankAccount = new EmployeeBankAccountFunction(Api);
            EmployeeBenefitCategory = new EmployeeBenefitCategoryFunction(Api);
            EmployeeDocument = new EmployeeDocumentFunction(Api);
            EmployeeEarningsLineSplit = new EmployeeEarningsLineSplitFunction(Api);
            EmployeeExpenseCategories = new EmployeeExpenseCategoriesFunction(Api);
            EmployeeExpenseRequest = new EmployeeExpenseRequestFunction(Api);
            EmployeeGroups = new EmployeeGroupsFunction(Api);
            EmployeeLeaveAllowances = new EmployeeLeaveAllowancesFunction(Api);
            EmployeeOnboarding = new EmployeeOnboardingFunction(Api);
            EmployeePayRateSchedule = new EmployeePayRateScheduleFunction(Api);
            EmployeeQualifications = new EmployeeQualificationsFunction(Api);
            EmployeeRecurringTransactions = new EmployeeRecurringTransactionsFunction(Api);
            EmployeeReportingDimensionEarningsLineSplit = new EmployeeReportingDimensionEarningsLineSplitFunction(Api);
            EmployerLiabilityCategories = new EmployerLiabilityCategoriesFunction(Api);
            EmploymentAgreement = new EmploymentAgreementFunction(Api);
            Ess = new EssFunction(Api);
            Invoices = new InvoicesFunction(Api);
            LeaveAllowance = new LeaveAllowanceFunction(Api);
            LeaveCategories = new LeaveCategoriesFunction(Api);
            LeaveRequests = new LeaveRequestsFunction(Api);
            LookupData = new LookupDataFunction(Api);
            Manager = new ManagerFunction(Api);
            Other = new OtherFunction(Api);
            PayCategory = new PayCategoryFunction(Api);
            PayCondition = new PayConditionFunction(Api);
            PayeScheme = new PayeSchemeFunction(Api);
            PayRateTemplate = new PayRateTemplateFunction(Api);
            PayRun = new PayRunFunction(Api);
            PaySchedule = new PayScheduleFunction(Api);
            PensionSettings = new PensionSettingsFunction(Api);
            PublicHoliday = new PublicHolidayFunction(Api);
            Qualifications = new QualificationsFunction(Api);
            ReportingDimensions = new ReportingDimensionsFunction(Api);
            RosterShift = new RosterShiftFunction(Api);
            Subcontractor = new SubcontractorFunction(Api);
            TimeAndAttendance = new TimeAndAttendanceFunction(Api);
            Timesheets = new TimesheetsFunction(Api);
            Unavailability = new UnavailabilityFunction(Api);
            User = new UserFunction(Api);
            Webhook = new WebhookFunction(Api);
            WorkType = new WorkTypeFunction(Api);
            Brand = new BrandFunction(Api);
            Reseller = new ResellerFunction(Api);
            WhiteLabel = new WhiteLabelFunction(Api);
            Reporting = new ReportingFunction(Api);
        }

        public IAuthenticationFunction Authentication { get; }
        public IBenefitCategoryFunction BenefitCategory { get; }
        public IBusinessFunction Business { get; }
        public IChartOfAccountsFunction ChartOfAccounts { get; }
        public IDeductionCategoriesFunction DeductionCategories { get; }
        public IEmployeeFunction Employee { get; }
        public IEmployeeAccessFunction EmployeeAccess { get; }
        public IEmployeeBankAccountFunction EmployeeBankAccount { get; }
        public IEmployeeBenefitCategoryFunction EmployeeBenefitCategory { get; }
        public IEmployeeDocumentFunction EmployeeDocument { get; }
        public IEmployeeEarningsLineSplitFunction EmployeeEarningsLineSplit { get; }
        public IEmployeeExpenseCategoriesFunction EmployeeExpenseCategories { get; }
        public IEmployeeExpenseRequestFunction EmployeeExpenseRequest { get; }
        public IEmployeeGroupsFunction EmployeeGroups { get; }
        public IEmployeeLeaveAllowancesFunction EmployeeLeaveAllowances { get; }
        public IEmployeeOnboardingFunction EmployeeOnboarding { get; }
        public IEmployeePayRateScheduleFunction EmployeePayRateSchedule { get; }
        public IEmployeeQualificationsFunction EmployeeQualifications { get; }
        public IEmployeeRecurringTransactionsFunction EmployeeRecurringTransactions { get; }
        public IEmployeeReportingDimensionEarningsLineSplitFunction EmployeeReportingDimensionEarningsLineSplit { get; }
        public IEmployerLiabilityCategoriesFunction EmployerLiabilityCategories { get; }
        public IEmploymentAgreementFunction EmploymentAgreement { get; }
        public IEssFunction Ess { get; }
        public IInvoicesFunction Invoices { get; }
        public ILeaveAllowanceFunction LeaveAllowance { get; }
        public ILeaveCategoriesFunction LeaveCategories { get; }
        public ILeaveRequestsFunction LeaveRequests { get; }
        public ILookupDataFunction LookupData { get; }
        public IManagerFunction Manager { get; }
        public IOtherFunction Other { get; }
        public IPayCategoryFunction PayCategory { get; }
        public IPayConditionFunction PayCondition { get; }
        public IPayeSchemeFunction PayeScheme { get; }
        public IPayRateTemplateFunction PayRateTemplate { get; }
        public IPayRunFunction PayRun { get; }
        public IPayScheduleFunction PaySchedule { get; }
        public IPensionSettingsFunction PensionSettings { get; }
        public IPublicHolidayFunction PublicHoliday { get; }
        public IQualificationsFunction Qualifications { get; }
        public IReportingDimensionsFunction ReportingDimensions { get; }
        public IRosterShiftFunction RosterShift { get; }
        public ISubcontractorFunction Subcontractor { get; }
        public ITimeAndAttendanceFunction TimeAndAttendance { get; }
        public ITimesheetsFunction Timesheets { get; }
        public IUnavailabilityFunction Unavailability { get; }
        public IUserFunction User { get; }
        public IWebhookFunction Webhook { get; }
        public IWorkTypeFunction WorkType { get; }
        public IBrandFunction Brand { get; }
        public IResellerFunction Reseller { get; }
        public IWhiteLabelFunction WhiteLabel { get; }
        public IReportingFunction Reporting { get; }
    }
}
