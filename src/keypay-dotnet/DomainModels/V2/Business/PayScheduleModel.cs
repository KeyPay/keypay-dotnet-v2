using KeyPay.Enums;

namespace KeyPay.DomainModels.V2.Business
{
    public class PayScheduleModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Frequency { get; set; }
        public string LastDatePaid { get; set; }
        public string LastPayRun { get; set; }
        public string ExternalId { get; set; }
        public string Source { get; set; }
        public int? AbaDetailsId { get; set; }
        public PayRunEmployeeSelectionStrategy EmployeeSelectionStrategy { get; set; }
    }
}