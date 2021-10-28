using KeyPayV2.Common;
using KeyPayV2.Common.Auth;
using KeyPayV2.Nz.Functions;

namespace KeyPayV2.Nz
{
    public class NzApiClient : BaseApiClient
    {
        public NzApiClient(string baseUrl, AuthenticationDetails authenticationDetails, string userAgent = null) : base(baseUrl, authenticationDetails, userAgent)
        {
            Brand = new BrandFunction(Api);
            Invoices = new InvoicesFunction(Api);
            Business = new BusinessFunction(Api);
            ChartOfAccounts = new ChartOfAccountsFunction(Api);
            DeductionCategories = new DeductionCategoriesFunction(Api);
            Employee = new EmployeeFunction(Api);
            EmployeeAccess = new EmployeeAccessFunction(Api);
            EmployeeBankAccount = new EmployeeBankAccountFunction(Api);
            EmployeeRecurringTransactions = new EmployeeRecurringTransactionsFunction(Api);
            EmployeeDocument = new EmployeeDocumentFunction(Api);
            EmployeeEarningsLineSplit = new EmployeeEarningsLineSplitFunction(Api);
            EmployeeExpenseRequest = new EmployeeExpenseRequestFunction(Api);
            EmployeeLeaveAllowances = new EmployeeLeaveAllowancesFunction(Api);
            LeaveAllowance = new LeaveAllowanceFunction(Api);
            LeaveRequests = new LeaveRequestsFunction(Api);
            Location = new LocationFunction(Api);
            EmployeePayRateSchedule = new EmployeePayRateScheduleFunction(Api);
            PayRun = new PayRunFunction(Api);
            EmployeeQualifications = new EmployeeQualificationsFunction(Api);
            Authentication = new AuthenticationFunction(Api);
            EmploymentAgreement = new EmploymentAgreementFunction(Api);
            EmployeeExpenseCategories = new EmployeeExpenseCategoriesFunction(Api);
            EmployeeGroups = new EmployeeGroupsFunction(Api);
            EmployeeOnboarding = new EmployeeOnboardingFunction(Api);
            EmployerLiabilityCategories = new EmployerLiabilityCategoriesFunction(Api);
            EmployingEntities = new EmployingEntitiesFunction(Api);
            TimeAndAttendance = new TimeAndAttendanceFunction(Api);
            LeaveCategories = new LeaveCategoriesFunction(Api);
            LookupData = new LookupDataFunction(Api);
            Manager = new ManagerFunction(Api);
            PayCategory = new PayCategoryFunction(Api);
            PayRateTemplate = new PayRateTemplateFunction(Api);
            Other = new OtherFunction(Api);
            PaySchedule = new PayScheduleFunction(Api);
            PublicHoliday = new PublicHolidayFunction(Api);
            Qualifications = new QualificationsFunction(Api);
            Reporting = new ReportingFunction(Api);
            RosterShift = new RosterShiftFunction(Api);
            Timesheets = new TimesheetsFunction(Api);
            Unavailability = new UnavailabilityFunction(Api);
            Webhook = new WebhookFunction(Api);
            WorkType = new WorkTypeFunction(Api);
            Ess = new EssFunction(Api);
            Reseller = new ResellerFunction(Api);
            User = new UserFunction(Api);
            WhiteLabel = new WhiteLabelFunction(Api);
        }

        public BrandFunction Brand { get; }
        public InvoicesFunction Invoices { get; }
        public BusinessFunction Business { get; }
        public ChartOfAccountsFunction ChartOfAccounts { get; }
        public DeductionCategoriesFunction DeductionCategories { get; }
        public EmployeeFunction Employee { get; }
        public EmployeeAccessFunction EmployeeAccess { get; }
        public EmployeeBankAccountFunction EmployeeBankAccount { get; }
        public EmployeeRecurringTransactionsFunction EmployeeRecurringTransactions { get; }
        public EmployeeDocumentFunction EmployeeDocument { get; }
        public EmployeeEarningsLineSplitFunction EmployeeEarningsLineSplit { get; }
        public EmployeeExpenseRequestFunction EmployeeExpenseRequest { get; }
        public EmployeeLeaveAllowancesFunction EmployeeLeaveAllowances { get; }
        public LeaveAllowanceFunction LeaveAllowance { get; }
        public LeaveRequestsFunction LeaveRequests { get; }
        public LocationFunction Location { get; }
        public EmployeePayRateScheduleFunction EmployeePayRateSchedule { get; }
        public PayRunFunction PayRun { get; }
        public EmployeeQualificationsFunction EmployeeQualifications { get; }
        public AuthenticationFunction Authentication { get; }
        public EmploymentAgreementFunction EmploymentAgreement { get; }
        public EmployeeExpenseCategoriesFunction EmployeeExpenseCategories { get; }
        public EmployeeGroupsFunction EmployeeGroups { get; }
        public EmployeeOnboardingFunction EmployeeOnboarding { get; }
        public EmployerLiabilityCategoriesFunction EmployerLiabilityCategories { get; }
        public EmployingEntitiesFunction EmployingEntities { get; }
        public TimeAndAttendanceFunction TimeAndAttendance { get; }
        public LeaveCategoriesFunction LeaveCategories { get; }
        public LookupDataFunction LookupData { get; }
        public ManagerFunction Manager { get; }
        public PayCategoryFunction PayCategory { get; }
        public PayRateTemplateFunction PayRateTemplate { get; }
        public OtherFunction Other { get; }
        public PayScheduleFunction PaySchedule { get; }
        public PublicHolidayFunction PublicHoliday { get; }
        public QualificationsFunction Qualifications { get; }
        public ReportingFunction Reporting { get; }
        public RosterShiftFunction RosterShift { get; }
        public TimesheetsFunction Timesheets { get; }
        public UnavailabilityFunction Unavailability { get; }
        public WebhookFunction Webhook { get; }
        public WorkTypeFunction WorkType { get; }
        public EssFunction Ess { get; }
        public ResellerFunction Reseller { get; }
        public UserFunction User { get; }
        public WhiteLabelFunction WhiteLabel { get; }
    }
}
