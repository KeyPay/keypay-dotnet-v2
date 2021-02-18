using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Business
{
    public class BusinessAction
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public int Id { get; set; }
    }
}
