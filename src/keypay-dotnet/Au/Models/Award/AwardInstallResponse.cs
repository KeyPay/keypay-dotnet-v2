using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Award
{
    public class AwardInstallResponse
    {
        public Guid? JobId { get; set; }
        public IList<EmployeeDto> EmployeesWithOverriddenRate { get; set; }
    }
}
