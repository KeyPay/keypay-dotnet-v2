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
        IEmployerLiabilityCategoriesFunction EmployerLiabilityCategories { get; }
        IEmployingEntitiesFunction EmployingEntities { get; }
        IInvoicesFunction Invoices { get; }
        ILeaveAllowanceFunction LeaveAllowance { get; }
        ILeaveCategoriesFunction LeaveCategories { get; }
        IOtherFunction Other { get; }
        IPayRunFunction PayRun { get; }
        IPublicHolidayFunction PublicHoliday { get; }
        IQualificationsFunction Qualifications { get; }
        IReportingFunction Reporting { get; }
        ITimeAndAttendanceFunction TimeAndAttendance { get; }
        IWebhookFunction Webhook { get; }
        IWhiteLabelFunction WhiteLabel { get; }
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
            EmployerLiabilityCategories = new EmployerLiabilityCategoriesFunction(Api);
            EmployingEntities = new EmployingEntitiesFunction(Api);
            Invoices = new InvoicesFunction(Api);
            LeaveAllowance = new LeaveAllowanceFunction(Api);
            LeaveCategories = new LeaveCategoriesFunction(Api);
            Other = new OtherFunction(Api);
            PayRun = new PayRunFunction(Api);
            PublicHoliday = new PublicHolidayFunction(Api);
            Qualifications = new QualificationsFunction(Api);
            Reporting = new ReportingFunction(Api);
            TimeAndAttendance = new TimeAndAttendanceFunction(Api);
            Webhook = new WebhookFunction(Api);
            WhiteLabel = new WhiteLabelFunction(Api);
        }

        public IAuthenticationFunction Authentication { get; }
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
        public IOtherFunction Other { get; }
        public IPayRunFunction PayRun { get; }
        public IPublicHolidayFunction PublicHoliday { get; }
        public IQualificationsFunction Qualifications { get; }
        public IReportingFunction Reporting { get; }
        public ITimeAndAttendanceFunction TimeAndAttendance { get; }
        public IWebhookFunction Webhook { get; }
        public IWhiteLabelFunction WhiteLabel { get; }
    }
}
