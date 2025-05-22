using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Ess
{
    public class SearchSuburbsQueryModel
    {
        public string Term { get; set; }
        public int PageNum { get; set; }
        public int PageSize { get; set; }
        public string CountryId { get; set; }
    }
}
