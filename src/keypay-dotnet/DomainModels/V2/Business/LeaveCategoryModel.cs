namespace KeyPay.DomainModels.V2.Business
{
    public class LeaveCategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UnitType { get; set; }
        public decimal Units { get; set; }
        public bool AutomaticallyAccrues { get; set; }
        public bool IsPrivate { get; set; }
        public bool ExcludeFromTerminationPayout { get; set; }
        public string ExternalId { get; set; }
        public string Source { get; set; }
        public decimal LeaveLoading { get; set; }
    }
}