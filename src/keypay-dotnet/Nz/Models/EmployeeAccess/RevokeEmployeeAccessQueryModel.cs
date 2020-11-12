using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.EmployeeAccess
{
    public class RevokeEmployeeAccessQueryModel
    {
        public string Email { get; set; }
    }
}
