using System;

namespace KeyPay.DomainModels.V2.Business
{
    public class UnavailabilityFilterModel
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? EmployeeId { get; set; }
        public int? DefaultLocationId { get; set; }
    }
}
