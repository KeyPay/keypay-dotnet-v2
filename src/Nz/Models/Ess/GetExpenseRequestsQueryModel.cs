using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Ess
{
    public class GetExpenseRequestsQueryModel
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
    }
}
