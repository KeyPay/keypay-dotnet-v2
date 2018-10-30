namespace KeyPay.DomainModels.V2.WorkType
{
    public class WorkTypeSelectModel : KeyValuePairViewModelBase
    {
        public bool IsUnitBased { get; set; }
        public bool IsLeaveType { get; set; }
        public string UnitType { get; set; }
    }
}