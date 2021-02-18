using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Manager
{
    public class TimesheetLineCommentsModel
    {
        public int Id { get; set; }
        public string Comments { get; set; }
        public string HiddenComments { get; set; }
    }
}
