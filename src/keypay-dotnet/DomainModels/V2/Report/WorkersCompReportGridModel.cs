namespace KeyPay.DomainModels.V2.Report
{
    public class WorkersCompReportGridModel
    {
        public int? EmployingEntityId { get; set; }
        public string EmployingEntity { get; set; }
        public int PayCategoryId { get; set; }
        public decimal EarningsReporting { get; set; }
        public decimal SuperContributionReporting { get; set; }
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public int ReportingLocationId { get; set; }
        public string ReportingLocationName { get; set; }
    }
}