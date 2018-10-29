namespace KeyPay.DomainModels.V2.TimeAndAttendance
{
    public class CheckKioskEmployeeIdModel
    {
        public int? EmployeeId { get; set; }
    }
    
    public class CheckKioskPinModel
    {
        public int? EmployeeId { get; set; }
        public string Pin { get; set; }
    }
    
    public class ChangeKioskPinModel
    {
        public int ?EmployeeId { get; set; }
        public string OldPin { get; set; }
        public string NewPin { get; set; }
    }

    public class GetKioskLookupDataModel
    {
        public int? KioskId { get; set; }
        public int? EmployeeId { get; set; }
    }
}