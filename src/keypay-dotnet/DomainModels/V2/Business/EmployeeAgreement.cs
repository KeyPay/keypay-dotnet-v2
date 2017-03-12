namespace KeyPay.DomainModels.V2.Business
{
    public class EmployeeAgreement
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int PayPoint { get; set; }
        public int EmpType { get; set; }
        public string CompanyName { get; set; }
        public bool Active { get; set; }
        public string StartDate { get; set; }
        public int Contract { get; set; }
        public int SalaryPayRule { get; set; }
        public int? ContractFile { get; set; }
        public string PayrollId { get; set; }
        public int PayPeriod { get; set; }
        public int HistoryId { get; set; }
        public int Creator { get; set; }
        public string Created { get; set; }
        public string Modified { get; set; }
    }
}