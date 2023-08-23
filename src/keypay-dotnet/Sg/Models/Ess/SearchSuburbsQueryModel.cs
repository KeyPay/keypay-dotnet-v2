using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Ess
{
    public class SearchSuburbsQueryModel
    {
        public string Term { get; set; }
        public int PageNum { get; set; }
        public int PageSize { get; set; }
        public string CountryId { get; set; }
    }
}
