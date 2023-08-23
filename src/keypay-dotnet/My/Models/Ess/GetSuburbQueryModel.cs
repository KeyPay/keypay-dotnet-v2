using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Ess
{
    public class GetSuburbQueryModel
    {
        public string Suburb { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }
        public string CountryId { get; set; }
    }
}
