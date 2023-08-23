using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.User
{
    public class UserAccountMetadataLite
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public List<MetadataLite> Relations { get; set; }
    }
}
