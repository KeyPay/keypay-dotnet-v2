using System.Collections.Generic;

namespace KeyPay.DomainModels.V2.Location
{
    public class LocationShiftConditionsModel
    {
        public int LocationId { get; set; }
        public IList<int> ShiftConditionIds { get; set; }
    }
}