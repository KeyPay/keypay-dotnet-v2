using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.User
{
    public class UserAccountMetadataLite
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public List<MetadataLite> Relations { get; set; }
    }
}
