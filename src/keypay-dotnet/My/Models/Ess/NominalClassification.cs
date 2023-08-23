using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Ess
{
    public class NominalClassification
    {
        public int Id { get; set; }
        public int Rank { get; set; }
        public string Name { get; set; }
    }
}
