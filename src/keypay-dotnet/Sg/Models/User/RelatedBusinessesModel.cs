using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.User
{
    public class RelatedBusinessesModel
    {
        public List<AbbreviatedBusinessModel> RelatedBusinesses { get; set; }
        public int UserId { get; set; }
    }
}
