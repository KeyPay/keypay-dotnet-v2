using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Reporting
{
    public class TasksReportNoteModel
    {
        public string Username { get; set; }
        public DateTime DateCreated { get; set; }
        public string Note { get; set; }
        public bool IsVisibleToManager { get; set; }
    }
}
