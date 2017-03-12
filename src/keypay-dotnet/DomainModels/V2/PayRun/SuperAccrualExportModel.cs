using System;

namespace KeyPay.DomainModels.V2.PayRun
{
    public class SuperAccrualExportModel
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string ExternalId { get; set; }
        public DateTime? AccrualDate { get; set; }
        public string AccrualType { get; set; }
        public decimal AccrualAmount { get; set; }
    }
}