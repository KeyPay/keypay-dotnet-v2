using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.EmployeeAccess
{
    public class CreateEmployeeAccessModel
    {
        public bool SuppressNotificationEmails { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
