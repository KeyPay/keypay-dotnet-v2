namespace KeyPay.DomainModels.V2.PayRun
{
    public class PaygAdjustmentModel
    {
        public virtual string Notes { get; set; }
        public virtual decimal Amount { get; set; }
        public int EmployeeId { get; set; }
        public int LocationId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
    }
}