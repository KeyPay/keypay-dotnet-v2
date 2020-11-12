using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.PublicHoliday
{
    public class PublicHolidayModel
    {
        public int? Id { get; set; }
        public DateTime? Date { get; set; }
        public IList<String> States { get; set; }
        public ICollection<Int32> LocationIds { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public bool IsSystem { get; set; }
        public bool NotAPublicHoliday { get; set; }
    }
}
