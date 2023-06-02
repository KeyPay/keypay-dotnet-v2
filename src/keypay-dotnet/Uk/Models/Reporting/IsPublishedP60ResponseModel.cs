using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class IsPublishedP60ResponseModel
    {
        public List<Int32> EmployeesPublished { get; set; }
        public List<Int32> EmployeesNotPublished { get; set; }
        public List<String> Errors { get; set; }
    }
}
