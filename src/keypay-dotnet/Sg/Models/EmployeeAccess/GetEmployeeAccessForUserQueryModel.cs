using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.EmployeeAccess
{
    public class GetEmployeeAccessForUserQueryModel
    {
        public string Email { get; set; }
    }
}
