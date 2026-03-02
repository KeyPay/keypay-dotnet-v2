using KeyPayV2.Common;
using KeyPayV2.Common.Auth;
using KeyPayV2.Sg.Functions;

namespace KeyPayV2.Sg
{
    public interface ISgApiClient : IBaseApiClient
    {
        IAuthenticationFunction Authentication { get; }
        IBrandFunction Brand { get; }
        IBusinessFunction Business { get; }
        IChartOfAccountsFunction ChartOfAccounts { get; }
        IDeductionCategoriesFunction DeductionCategories { get; }
        IEmployeeFunction Employee { get; }
        IEmployeeAccessFunction EmployeeAccess { get; }
        IEmployeeBankAccountFunction EmployeeBankAccount { get; }
        IEmployeeBenefitsInKindFunction EmployeeBenefitsInKind { get; }
        IEmployeeDocumentFunction EmployeeDocument { get; }
        IEmployeeEarningsLineSplitFunction EmployeeEarningsLineSplit { get; }
        IEmployeeExpenseCategoriesFunction EmployeeExpenseCategories { get; }
        IEmployeeExpenseRequestFunction EmployeeExpenseRequest { get; }
        IEmployeeGainsOrProfitsEmployeeSharePlanFunction EmployeeGainsOrProfitsEmployeeSharePlan { get; }
        IEmployeeGroupsFunction EmployeeGroups { get; }
        IEmployeeIncomeFromOverseasSubjectToTaxRemissionFunction EmployeeIncomeFromOverseasSubjectToTaxRemission { get; }
        IEmployeeIncomeTaxBorneByEmployerFunction EmployeeIncomeTaxBorneByEmployer { get; }
        IEmployeeIrasLumpSumFunction EmployeeIrasLumpSum { get; }
        IEmployeeLeaveAllowancesFunction EmployeeLeaveAllowances { get; }
        IEmployeeOnboardingFunction EmployeeOnboarding { get; }
        IEmployeePayRateScheduleFunction EmployeePayRateSchedule { get; }
        IEmployeeQualificationsFunction EmployeeQualifications { get; }
        IEmployeeRecurringTransactionsFunction EmployeeRecurringTransactions { get; }
        IEmployeeReportingDimensionEarningsLineSplitFunction EmployeeReportingDimensionEarningsLineSplit { get; }
        IEmployerLiabilityCategoriesFunction EmployerLiabilityCategories { get; }
        IEmployingEntitiesFunction EmployingEntities { get; }
        IEmploymentAgreementFunction EmploymentAgreement { get; }
        IEssFunction Ess { get; }
        IInvoicesFunction Invoices { get; }
        ILeaveAllowanceFunction LeaveAllowance { get; }
        ILeaveCategoriesFunction LeaveCategories { get; }
        ILeaveRequestsFunction LeaveRequests { get; }
        ILocationFunction Location { get; }
        ILookupDataFunction LookupData { get; }
        IManagerFunction Manager { get; }
        IOtherFunction Other { get; }
        IPayCategoryFunction PayCategory { get; }
        IPayConditionFunction PayCondition { get; }
        IPayRateTemplateFunction PayRateTemplate { get; }
        IPayRunFunction PayRun { get; }
        IPayScheduleFunction PaySchedule { get; }
        IPublicHolidayFunction PublicHoliday { get; }
        IQualificationsFunction Qualifications { get; }
        IReportingDimensionsFunction ReportingDimensions { get; }
        IResellerFunction Reseller { get; }
        IRosterShiftFunction RosterShift { get; }
        ITieredLeaveAllowanceFunction TieredLeaveAllowance { get; }
        ITimeAndAttendanceFunction TimeAndAttendance { get; }
        ITimesheetsFunction Timesheets { get; }
        IUnavailabilityFunction Unavailability { get; }
        IUserFunction User { get; }
        IWebhookFunction Webhook { get; }
        IWhiteLabelFunction WhiteLabel { get; }
        IWorkTypeFunction WorkType { get; }
        IReportingFunction Reporting { get; }
    }
    public class SgApiClient : BaseApiClient, ISgApiClient
    {
        public SgApiClient(string baseUrl, AuthenticationDetails authenticationDetails, string userAgent = null) : base(baseUrl, authenticationDetails, userAgent)
        {
            Authentication = new AuthenticationFunction(Api);
            Brand = new BrandFunction(Api);
            Business = new BusinessFunction(Api);
            ChartOfAccounts = new ChartOfAccountsFunction(Api);
            DeductionCategories = new DeductionCategoriesFunction(Api);
            Employee = new EmployeeFunction(Api);
            EmployeeAccess = new EmployeeAccessFunction(Api);
            EmployeeBankAccount = new EmployeeBankAccountFunction(Api);
            EmployeeBenefitsInKind = new EmployeeBenefitsInKindFunction(Api);
            EmployeeDocument = new EmployeeDocumentFunction(Api);
            EmployeeEarningsLineSplit = new EmployeeEarningsLineSplitFunction(Api);
            EmployeeExpenseCategories = new EmployeeExpenseCategoriesFunction(Api);
            EmployeeExpenseRequest = new EmployeeExpenseRequestFunction(Api);
            EmployeeGainsOrProfitsEmployeeSharePlan = new EmployeeGainsOrProfitsEmployeeSharePlanFunction(Api);
            EmployeeGroups = new EmployeeGroupsFunction(Api);
            EmployeeIncomeFromOverseasSubjectToTaxRemission = new EmployeeIncomeFromOverseasSubjectToTaxRemissionFunction(Api);
            EmployeeIncomeTaxBorneByEmployer = new EmployeeIncomeTaxBorneByEmployerFunction(Api);
            EmployeeIrasLumpSum = new EmployeeIrasLumpSumFunction(Api);
            EmployeeLeaveAllowances = new EmployeeLeaveAllowancesFunction(Api);
            EmployeeOnboarding = new EmployeeOnboardingFunction(Api);
            EmployeePayRateSchedule = new EmployeePayRateScheduleFunction(Api);
            EmployeeQualifications = new EmployeeQualificationsFunction(Api);
            EmployeeRecurringTransactions = new EmployeeRecurringTransactionsFunction(Api);
            EmployeeReportingDimensionEarningsLineSplit = new EmployeeReportingDimensionEarningsLineSplitFunction(Api);
            EmployerLiabilityCategories = new EmployerLiabilityCategoriesFunction(Api);
            EmployingEntities = new EmployingEntitiesFunction(Api);
            EmploymentAgreement = new EmploymentAgreementFunction(Api);
            Ess = new EssFunction(Api);
            Invoices = new InvoicesFunction(Api);
            LeaveAllowance = new LeaveAllowanceFunction(Api);
            LeaveCategories = new LeaveCategoriesFunction(Api);
            LeaveRequests = new LeaveRequestsFunction(Api);
            Location = new LocationFunction(Api);
            LookupData = new LookupDataFunction(Api);
            Manager = new ManagerFunction(Api);
            Other = new OtherFunction(Api);
            PayCategory = new PayCategoryFunction(Api);
            PayCondition = new PayConditionFunction(Api);
            PayRateTemplate = new PayRateTemplateFunction(Api);
            PayRun = new PayRunFunction(Api);
            PaySchedule = new PayScheduleFunction(Api);
            PublicHoliday = new PublicHolidayFunction(Api);
            Qualifications = new QualificationsFunction(Api);
            ReportingDimensions = new ReportingDimensionsFunction(Api);
            Reseller = new ResellerFunction(Api);
            RosterShift = new RosterShiftFunction(Api);
            TieredLeaveAllowance = new TieredLeaveAllowanceFunction(Api);
            TimeAndAttendance = new TimeAndAttendanceFunction(Api);
            Timesheets = new TimesheetsFunction(Api);
            Unavailability = new UnavailabilityFunction(Api);
            User = new UserFunction(Api);
            Webhook = new WebhookFunction(Api);
            WhiteLabel = new WhiteLabelFunction(Api);
            WorkType = new WorkTypeFunction(Api);
            Reporting = new ReportingFunction(Api);
        }

        public IAuthenticationFunction Authentication { get; }
        public IBrandFunction Brand { get; }
        public IBusinessFunction Business { get; }
        public IChartOfAccountsFunction ChartOfAccounts { get; }
        public IDeductionCategoriesFunction DeductionCategories { get; }
        public IEmployeeFunction Employee { get; }
        public IEmployeeAccessFunction EmployeeAccess { get; }
        public IEmployeeBankAccountFunction EmployeeBankAccount { get; }
        public IEmployeeBenefitsInKindFunction EmployeeBenefitsInKind { get; }
        public IEmployeeDocumentFunction EmployeeDocument { get; }
        public IEmployeeEarningsLineSplitFunction EmployeeEarningsLineSplit { get; }
        public IEmployeeExpenseCategoriesFunction EmployeeExpenseCategories { get; }
        public IEmployeeExpenseRequestFunction EmployeeExpenseRequest { get; }
        public IEmployeeGainsOrProfitsEmployeeSharePlanFunction EmployeeGainsOrProfitsEmployeeSharePlan { get; }
        public IEmployeeGroupsFunction EmployeeGroups { get; }
        public IEmployeeIncomeFromOverseasSubjectToTaxRemissionFunction EmployeeIncomeFromOverseasSubjectToTaxRemission { get; }
        public IEmployeeIncomeTaxBorneByEmployerFunction EmployeeIncomeTaxBorneByEmployer { get; }
        public IEmployeeIrasLumpSumFunction EmployeeIrasLumpSum { get; }
        public IEmployeeLeaveAllowancesFunction EmployeeLeaveAllowances { get; }
        public IEmployeeOnboardingFunction EmployeeOnboarding { get; }
        public IEmployeePayRateScheduleFunction EmployeePayRateSchedule { get; }
        public IEmployeeQualificationsFunction EmployeeQualifications { get; }
        public IEmployeeRecurringTransactionsFunction EmployeeRecurringTransactions { get; }
        public IEmployeeReportingDimensionEarningsLineSplitFunction EmployeeReportingDimensionEarningsLineSplit { get; }
        public IEmployerLiabilityCategoriesFunction EmployerLiabilityCategories { get; }
        public IEmployingEntitiesFunction EmployingEntities { get; }
        public IEmploymentAgreementFunction EmploymentAgreement { get; }
        public IEssFunction Ess { get; }
        public IInvoicesFunction Invoices { get; }
        public ILeaveAllowanceFunction LeaveAllowance { get; }
        public ILeaveCategoriesFunction LeaveCategories { get; }
        public ILeaveRequestsFunction LeaveRequests { get; }
        public ILocationFunction Location { get; }
        public ILookupDataFunction LookupData { get; }
        public IManagerFunction Manager { get; }
        public IOtherFunction Other { get; }
        public IPayCategoryFunction PayCategory { get; }
        public IPayConditionFunction PayCondition { get; }
        public IPayRateTemplateFunction PayRateTemplate { get; }
        public IPayRunFunction PayRun { get; }
        public IPayScheduleFunction PaySchedule { get; }
        public IPublicHolidayFunction PublicHoliday { get; }
        public IQualificationsFunction Qualifications { get; }
        public IReportingDimensionsFunction ReportingDimensions { get; }
        public IResellerFunction Reseller { get; }
        public IRosterShiftFunction RosterShift { get; }
        public ITieredLeaveAllowanceFunction TieredLeaveAllowance { get; }
        public ITimeAndAttendanceFunction TimeAndAttendance { get; }
        public ITimesheetsFunction Timesheets { get; }
        public IUnavailabilityFunction Unavailability { get; }
        public IUserFunction User { get; }
        public IWebhookFunction Webhook { get; }
        public IWhiteLabelFunction WhiteLabel { get; }
        public IWorkTypeFunction WorkType { get; }
        public IReportingFunction Reporting { get; }
    }
}
