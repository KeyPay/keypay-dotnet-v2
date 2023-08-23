using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.User
{
    public class RelatedBusinessesModel
    {
        public List<AbbreviatedBusinessModel> RelatedBusinesses { get; set; }
        public int UserId { get; set; }
    }
}
