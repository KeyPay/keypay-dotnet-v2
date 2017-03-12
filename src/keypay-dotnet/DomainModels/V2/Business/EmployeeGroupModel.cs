using System.Collections.Generic;
using KeyPay.Enums;

namespace KeyPay.DomainModels.V2.Business
{
    public class EmployeeGroupModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FilterCombinationStrategy FilterCombinationStrategy { get; set; }
        public IList<EmployeeFilterModel> Filters { get; set; }
    }
}