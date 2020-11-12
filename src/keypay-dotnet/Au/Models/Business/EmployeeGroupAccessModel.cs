using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Business
{
    public class EmployeeGroupAccessModel
    {
        public int EmployeeGroupId { get; set; }
        public UserPermission Permissions { get; set; }
    }
}
