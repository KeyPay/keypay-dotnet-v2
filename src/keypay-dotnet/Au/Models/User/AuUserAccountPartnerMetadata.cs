using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.User
{
    public class AuUserAccountPartnerMetadata
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public List<Int32> PartnerIds { get; set; }
    }
}
