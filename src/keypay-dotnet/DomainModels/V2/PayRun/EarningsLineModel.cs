namespace KeyPay.DomainModels.V2.PayRun
{
    public class EarningsLineModel
    {
        public string ExternalId { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeExternalId { get; set; }
        public string PayCategoryId { get; set; }
        public string PayCategoryName { get; set; }
        public decimal Units { get; set; }
        public string Notes { get; set; }
        public decimal? Rate { get; set; }
        public decimal Earnings { get; set; }
        public decimal Super { get; set; }
        public decimal Sfss { get; set; }
        public decimal Help { get; set; }
        public decimal Payg { get; set; }
        public decimal LumpSumNumberOfPayPeriods { get; set; }
        public int? TimesheetLineId { get; set; }
        public string TimesheetLineExternalId { get; set; }
    }
}