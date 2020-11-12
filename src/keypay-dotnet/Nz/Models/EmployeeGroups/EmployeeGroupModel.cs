using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.EmployeeGroups
{
    public class EmployeeGroupModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FilterCombinationStrategyEnum FilterCombinationStrategy { get; set; }
        public IList<EmployeeFilterModel> Filters { get; set; }
    }
}
