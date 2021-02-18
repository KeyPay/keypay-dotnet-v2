using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Common
{
    public class NominalLocation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
    }
}
