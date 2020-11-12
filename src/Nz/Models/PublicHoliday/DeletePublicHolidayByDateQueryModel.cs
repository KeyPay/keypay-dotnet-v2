using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.PublicHoliday
{
    public class DeletePublicHolidayByDateQueryModel
    {
        public DateTime Date { get; set; }
    }
}
