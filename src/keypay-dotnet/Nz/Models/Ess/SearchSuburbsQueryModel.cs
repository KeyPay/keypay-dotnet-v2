using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Ess
{
    public class SearchSuburbsQueryModel
    {
        public string Term { get; set; }
        public int PageNum { get; set; }
        public int PageSize { get; set; }
        public string CountryId { get; set; }
    }
}
