using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.EmployingEntities
{
    public class ListEmployingEntitiesQueryModel
    {
        public string Query { get; set; }
        public bool IncludeInactive { get; set; }
    }
}
