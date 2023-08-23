using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.User
{
    public class RelatedBusinessesModel
    {
        public List<AbbreviatedBusinessModel> RelatedBusinesses { get; set; }
        public int UserId { get; set; }
    }
}
