using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Ess
{
    public class NominalLocation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
    }
}
