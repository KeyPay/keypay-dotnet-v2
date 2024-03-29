using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.SuperFund
{
    public class SearchSuperFundsQueryModel
    {
        public string Term { get; set; }
        public SuperFundSearchBy SearchBy { get; set; }
    }
}
