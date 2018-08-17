using System.ComponentModel;

namespace KeyPay.Enums
{
    public enum LocationRestrictionFilterTypeEnum
    {
        Location = 1,
        [Description("Location and any Sub-locations")]
        LocationOrParents = 2
    }
}