using KeyPay.Enums;

namespace KeyPay.DomainModels.V2.Business
{
    public class EmployeeFilterModel
    {
        public FilterType FilterType { get; set; }
        public FilterOperator Operator { get; set; }
        public string Value { get; set; }
    }
}