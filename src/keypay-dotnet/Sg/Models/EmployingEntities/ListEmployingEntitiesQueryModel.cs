using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.EmployingEntities
{
    public class ListEmployingEntitiesQueryModel
    {
        public string Query { get; set; }
        public bool IncludeInactive { get; set; }
    }
}
