using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.Other
{
    public class TasksReportNoteModel
    {
        public string Username { get; set; }
        public DateTime DateCreated { get; set; }
        public string Note { get; set; }
        public bool IsVisibleToManager { get; set; }
    }
}
