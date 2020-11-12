using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Ess
{
    public class GetExpenseRequestsQueryModel
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
    }
}
