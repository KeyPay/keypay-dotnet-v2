namespace KeyPay.DomainModels.V2.Employee
{
    public class LeaveAllowanceModel
    {
        public string LeaveCategoryId { get; set; }
        public string LeaveCategoryName { get; set; }
        public decimal Units { get; set; }
        public string UnitType { get; set; }
        public decimal HoursPerYear { get; set; }
        public bool AutomaticallyAccrues { get; set; }
        public decimal LeaveLoading { get; set; }
    }
}