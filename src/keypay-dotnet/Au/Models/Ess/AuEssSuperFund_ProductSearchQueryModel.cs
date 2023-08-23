using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Ess
{
    public class AuEssSuperFund_ProductSearchQueryModel
    {
        public string Term { get; set; }
        public SuperFundSearchBy SearchBy { get; set; }
    }
}
