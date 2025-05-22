using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Business
{
    public class PgpKeyEditModel
    {
        public int Id { get; set; }
        public int BusinessId { get; set; }
        public string KeyName { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
