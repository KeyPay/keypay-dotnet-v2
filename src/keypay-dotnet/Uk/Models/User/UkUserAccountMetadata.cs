using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.User
{
    public class UkUserAccountMetadata
    {
        public List<UkAvailableBusinessModel> Businesses { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public List<AvailableEmployeeModel> Employees { get; set; }
    }
}
