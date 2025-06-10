using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class UkSspUpdateModel
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public UkOspUpdateModel Osp { get; set; }
    }
}
