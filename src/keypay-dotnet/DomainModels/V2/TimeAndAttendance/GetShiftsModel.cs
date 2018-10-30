using System;

namespace KeyPay.DomainModels.V2.TimeAndAttendance
{
    public class GetShiftsModel
    {
        public int? KioskId { get; set; }
        public int? LocationId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? FromDateUtc { get; set; }
        public DateTime? ToDateUtc { get; set; }
    }
}