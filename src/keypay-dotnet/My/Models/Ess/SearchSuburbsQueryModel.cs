using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Ess
{
    public class SearchSuburbsQueryModel
    {
        public string Term { get; set; }
        public int PageNum { get; set; }
        public int PageSize { get; set; }
        public string CountryId { get; set; }
    }
}
