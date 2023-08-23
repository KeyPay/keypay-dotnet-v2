using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Business
{
    public class BusinessAction
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public int Id { get; set; }
        public bool HighPriority { get; set; }
    }
}
