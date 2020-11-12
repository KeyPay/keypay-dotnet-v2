using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Business
{
    public class EmployeeGroupAccessModel
    {
        public int EmployeeGroupId { get; set; }
        public UserPermission Permissions { get; set; }
    }
}
