using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.PayCondition
{
    public class AwardTagDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BusinessAwardPackageId { get; set; }
    }
}
