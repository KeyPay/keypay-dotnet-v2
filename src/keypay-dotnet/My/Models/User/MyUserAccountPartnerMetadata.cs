using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.User
{
    public class MyUserAccountPartnerMetadata
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public List<Int32> PartnerIds { get; set; }
    }
}
