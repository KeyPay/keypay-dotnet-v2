using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.EmployingEntities
{
    public class ListEmployingEntitiesQueryModel
    {
        public string Query { get; set; }
        public bool IncludeInactive { get; set; }
    }
}
