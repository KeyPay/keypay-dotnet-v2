using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Other
{
    public class TasksReportNoteModel
    {
        public string Username { get; set; }
        public DateTime DateCreated { get; set; }
        public string Note { get; set; }
        public bool IsVisibleToManager { get; set; }
    }
}
