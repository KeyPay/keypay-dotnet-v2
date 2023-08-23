using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.User
{
    public class RelatedBusinessesModel
    {
        public List<AbbreviatedBusinessModel> RelatedBusinesses { get; set; }
        public int UserId { get; set; }
    }
}
