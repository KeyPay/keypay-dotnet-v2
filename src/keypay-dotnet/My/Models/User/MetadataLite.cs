using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.User
{
    public class MetadataLite
    {
        public int? EmployeeId { get; set; }
        public int BusinessId { get; set; }
        public int BrandId { get; set; }
        public int? PartnerId { get; set; }
    }
}
