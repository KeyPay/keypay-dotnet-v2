using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.EmployeeGroups
{
    public class EmployeeFilterModel
    {
        public FilterTypeEnum FilterType { get; set; }
        public FilterOperatorEnum Operator { get; set; }
        public string Value { get; set; }
    }
}