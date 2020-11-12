using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.EmployeeAccess
{
    public class CreateEmployeeAccessModel
    {
        public bool SuppressNotificationEmails { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
