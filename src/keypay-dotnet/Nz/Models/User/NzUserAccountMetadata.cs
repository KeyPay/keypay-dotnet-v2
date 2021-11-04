using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.User
{
    public class NzUserAccountMetadata
    {
        public List<NzAvailableBusinessModel> Businesses { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public List<AvailableEmployeeModel> Employees { get; set; }
    }
}
