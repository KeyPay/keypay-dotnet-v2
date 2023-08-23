using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.PublicHoliday
{
    public class GetPublicHolidaysForYearQueryModel
    {
        public int Year { get; set; }
    }
}
