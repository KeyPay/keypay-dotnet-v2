using KeyPayV2.Common;
using KeyPayV2.Common.Auth;
using KeyPayV2.Sg.Functions;

namespace KeyPayV2.Sg
{
    public interface ISgApiClient : IBaseApiClient
    {
        IBrandFunction Brand { get; }
        IBusinessFunction Business { get; }
        IChartOfAccountsFunction ChartOfAccounts { get; }
        IEmployeeExpenseCategoriesFunction EmployeeExpenseCategories { get; }
        IEmployerLiabilityCategoriesFunction EmployerLiabilityCategories { get; }
        IEmployingEntitiesFunction EmployingEntities { get; }
        IInvoicesFunction Invoices { get; }
        IOtherFunction Other { get; }
        IPayRunFunction PayRun { get; }
        IQualificationsFunction Qualifications { get; }
        IReportingFunction Reporting { get; }
        ITimeAndAttendanceFunction TimeAndAttendance { get; }
        IWebhookFunction Webhook { get; }
        IWhiteLabelFunction WhiteLabel { get; }
        IDeductionCategoriesFunction DeductionCategories { get; }
        IReportingDimensionsFunction ReportingDimensions { get; }
        IEmployeeFunction Employee { get; }
        IEmployeeAccessFunction EmployeeAccess { get; }
        IEmployeeRecurringTransactionsFunction EmployeeRecurringTransactions { get; }
        IEmployeeBankAccountFunction EmployeeBankAccount { get; }
        IEmployeeBenefitsInKindFunction EmployeeBenefitsInKind { get; }
        IEmployeeDocumentFunction EmployeeDocument { get; }
        IEmployeeEarningsLineSplitFunction EmployeeEarningsLineSplit { get; }
        IEmployeeReportingDimensionEarningsLineSplitFunction EmployeeReportingDimensionEarningsLineSplit { get; }
        IEmployeeExpenseRequestFunction EmployeeExpenseRequest { get; }
        IEmployeeGainsOrProfitsEmployeeSharePlanFunction EmployeeGainsOrProfitsEmployeeSharePlan { get; }
        IEmployeeIncomeFromOverseasSubjectToTaxRemissionFunction EmployeeIncomeFromOverseasSubjectToTaxRemission { get; }
        IEmployeeIncomeTaxBorneByEmployerFunction EmployeeIncomeTaxBorneByEmployer { get; }
        IEmployeeLeaveAllowancesFunction EmployeeLeaveAllowances { get; }
        ILeaveAllowanceFunction LeaveAllowance { get; }
        ILeaveRequestsFunction LeaveRequests { get; }
        ILocationFunction Location { get; }
        IEmployeeIrasLumpSumFunction EmployeeIrasLumpSum { get; }
        IEmployeePayRateScheduleFunction EmployeePayRateSchedule { get; }
        IEmployeeQualificationsFunction EmployeeQualifications { get; }
        IAuthenticationFunction Authentication { get; }
        IEmploymentAgreementFunction EmploymentAgreement { get; }
        IEmployeeGroupsFunction EmployeeGroups { get; }
        IEmployeeOnboardingFunction EmployeeOnboarding { get; }
        ILeaveCategoriesFunction LeaveCategories { get; }
        ILookupDataFunction LookupData { get; }
        IManagerFunction Manager { get; }
        IPayCategoryFunction PayCategory { get; }
        IPayRateTemplateFunction PayRateTemplate { get; }
        IPayScheduleFunction PaySchedule { get; }
        IPublicHolidayFunction PublicHoliday { get; }
        IRosterShiftFunction RosterShift { get; }
        ITieredLeaveAllowanceFunction TieredLeaveAllowance { get; }
        ITimesheetsFunction Timesheets { get; }
        IUnavailabilityFunction Unavailability { get; }
        IWorkTypeFunction WorkType { get; }
        IEssFunction Ess { get; }
        IResellerFunction Reseller { get; }
        IUserFunction User { get; }
    }
    public class SgApiClient : BaseApiClient, ISgApiClient
    {
        public SgApiClient(string baseUrl, AuthenticationDetails authenticationDetails, string userAgent = null) : base(baseUrl, authenticationDetails, userAgent)
        {
            Brand = new BrandFunction(Api);
            Business = new BusinessFunction(Api);
            ChartOfAccounts = new ChartOfAccountsFunction(Api);
            EmployeeExpenseCategories = new EmployeeExpenseCategoriesFunction(Api);
            EmployerLiabilityCategories = new EmployerLiabilityCategoriesFunction(Api);
            EmployingEntities = new EmployingEntitiesFunction(Api);
            Invoices = new InvoicesFunction(Api);
            Other = new OtherFunction(Api);
            PayRun = new PayRunFunction(Api);
            Qualifications = new QualificationsFunction(Api);
            Reporting = new ReportingFunction(Api);
            TimeAndAttendance = new TimeAndAttendanceFunction(Api);
            Webhook = new WebhookFunction(Api);
            WhiteLabel = new WhiteLabelFunction(Api);
            DeductionCategories = new DeductionCategoriesFunction(Api);
            ReportingDimensions = new ReportingDimensionsFunction(Api);
            Employee = new EmployeeFunction(Api);
            EmployeeAccess = new EmployeeAccessFunction(Api);
            EmployeeRecurringTransactions = new EmployeeRecurringTransactionsFunction(Api);
            EmployeeBankAccount = new EmployeeBankAccountFunction(Api);
            EmployeeBenefitsInKind = new EmployeeBenefitsInKindFunction(Api);
            EmployeeDocument = new EmployeeDocumentFunction(Api);
            EmployeeEarningsLineSplit = new EmployeeEarningsLineSplitFunction(Api);
            EmployeeReportingDimensionEarningsLineSplit = new EmployeeReportingDimensionEarningsLineSplitFunction(Api);
            EmployeeExpenseRequest = new EmployeeExpenseRequestFunction(Api);
            EmployeeGainsOrProfitsEmployeeSharePlan = new EmployeeGainsOrProfitsEmployeeSharePlanFunction(Api);
            EmployeeIncomeFromOverseasSubjectToTaxRemission = new EmployeeIncomeFromOverseasSubjectToTaxRemissionFunction(Api);
            EmployeeIncomeTaxBorneByEmployer = new EmployeeIncomeTaxBorneByEmployerFunction(Api);
            EmployeeLeaveAllowances = new EmployeeLeaveAllowancesFunction(Api);
            LeaveAllowance = new LeaveAllowanceFunction(Api);
            LeaveRequests = new LeaveRequestsFunction(Api);
            Location = new LocationFunction(Api);
            EmployeeIrasLumpSum = new EmployeeIrasLumpSumFunction(Api);
            EmployeePayRateSchedule = new EmployeePayRateScheduleFunction(Api);
            EmployeeQualifications = new EmployeeQualificationsFunction(Api);
            Authentication = new AuthenticationFunction(Api);
            EmploymentAgreement = new EmploymentAgreementFunction(Api);
            EmployeeGroups = new EmployeeGroupsFunction(Api);
            EmployeeOnboarding = new EmployeeOnboardingFunction(Api);
            LeaveCategories = new LeaveCategoriesFunction(Api);
            LookupData = new LookupDataFunction(Api);
            Manager = new ManagerFunction(Api);
            PayCategory = new PayCategoryFunction(Api);
            PayRateTemplate = new PayRateTemplateFunction(Api);
            PaySchedule = new PayScheduleFunction(Api);
            PublicHoliday = new PublicHolidayFunction(Api);
            RosterShift = new RosterShiftFunction(Api);
            TieredLeaveAllowance = new TieredLeaveAllowanceFunction(Api);
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
        public IEmployeeExpenseCategoriesFunction EmployeeExpenseCategories { get; }
        public IEmployerLiabilityCategoriesFunction EmployerLiabilityCategories { get; }
        public IEmployingEntitiesFunction EmployingEntities { get; }
        public IInvoicesFunction Invoices { get; }
        public IOtherFunction Other { get; }
        public IPayRunFunction PayRun { get; }
        public IQualificationsFunction Qualifications { get; }
        public IReportingFunction Reporting { get; }
        public ITimeAndAttendanceFunction TimeAndAttendance { get; }
        public IWebhookFunction Webhook { get; }
        public IWhiteLabelFunction WhiteLabel { get; }
        public IDeductionCategoriesFunction DeductionCategories { get; }
        public IReportingDimensionsFunction ReportingDimensions { get; }
        public IEmployeeFunction Employee { get; }
        public IEmployeeAccessFunction EmployeeAccess { get; }
        public IEmployeeRecurringTransactionsFunction EmployeeRecurringTransactions { get; }
        public IEmployeeBankAccountFunction EmployeeBankAccount { get; }
        public IEmployeeBenefitsInKindFunction EmployeeBenefitsInKind { get; }
        public IEmployeeDocumentFunction EmployeeDocument { get; }
        public IEmployeeEarningsLineSplitFunction EmployeeEarningsLineSplit { get; }
        public IEmployeeReportingDimensionEarningsLineSplitFunction EmployeeReportingDimensionEarningsLineSplit { get; }
        public IEmployeeExpenseRequestFunction EmployeeExpenseRequest { get; }
        public IEmployeeGainsOrProfitsEmployeeSharePlanFunction EmployeeGainsOrProfitsEmployeeSharePlan { get; }
        public IEmployeeIncomeFromOverseasSubjectToTaxRemissionFunction EmployeeIncomeFromOverseasSubjectToTaxRemission { get; }
        public IEmployeeIncomeTaxBorneByEmployerFunction EmployeeIncomeTaxBorneByEmployer { get; }
        public IEmployeeLeaveAllowancesFunction EmployeeLeaveAllowances { get; }
        public ILeaveAllowanceFunction LeaveAllowance { get; }
        public ILeaveRequestsFunction LeaveRequests { get; }
        public ILocationFunction Location { get; }
        public IEmployeeIrasLumpSumFunction EmployeeIrasLumpSum { get; }
        public IEmployeePayRateScheduleFunction EmployeePayRateSchedule { get; }
        public IEmployeeQualificationsFunction EmployeeQualifications { get; }
        public IAuthenticationFunction Authentication { get; }
        public IEmploymentAgreementFunction EmploymentAgreement { get; }
        public IEmployeeGroupsFunction EmployeeGroups { get; }
        public IEmployeeOnboardingFunction EmployeeOnboarding { get; }
        public ILeaveCategoriesFunction LeaveCategories { get; }
        public ILookupDataFunction LookupData { get; }
        public IManagerFunction Manager { get; }
        public IPayCategoryFunction PayCategory { get; }
        public IPayRateTemplateFunction PayRateTemplate { get; }
        public IPayScheduleFunction PaySchedule { get; }
        public IPublicHolidayFunction PublicHoliday { get; }
        public IRosterShiftFunction RosterShift { get; }
        public ITieredLeaveAllowanceFunction TieredLeaveAllowance { get; }
        public ITimesheetsFunction Timesheets { get; }
        public IUnavailabilityFunction Unavailability { get; }
        public IWorkTypeFunction WorkType { get; }
        public IEssFunction Ess { get; }
        public IResellerFunction Reseller { get; }
        public IUserFunction User { get; }
    }
}
