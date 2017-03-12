namespace KeyPay.DomainModels.V2.PayRun
{
    public class LeaveCategoryGridModel
    {
        public int Id { get; set; }
        public int BusinessId { get; set; }
        public string LeaveCategoryName { get; set; }
        public decimal Units { get; set; }
        public string UnitType { get; set; }
        public bool IsDeleted { get; set; }
        public bool AutomaticallyAccrues { get; set; }
        public bool IsPrivate { get; set; }
        public bool ExcludeFromTerminationPayout { get; set; }
        public string Source { get; set; }
    }
}