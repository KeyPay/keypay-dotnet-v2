using KeyPay.Enums;

namespace KeyPay.DomainModels.V2.Business
{
    public class LeaveCategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public LeaveAllowanceUnit UnitType { get; set; }
        public decimal Units { get; set; }
        public bool AutomaticallyAccrues { get; set; }
        public bool IsPrivate { get; set; }
        public bool ExcludeFromTerminationPayout { get; set; }
        public string ExternalId { get; set; }
        public string Source { get; set; }
        public decimal LeaveLoading { get; set; }
        public decimal? ContingentPeriod { get; set; }
        public decimal? EntitlementPeriod { get; set; }
        public bool IsBalanceUntracked { get; set; }
        public LeaveCategoryType LeaveCategoryType { get; set; }
        public bool DeductFromPrimaryPayCategory { get; set; }
        public int? DeductFromPayCategoryId { get; set; }
        public int? TransferToPayCategoryId { get; set; }
        public bool HideAccrualsOnPayslip { get; set; }
        public bool UseDeductFromPayCategoryRate { get; set; }
    }
}