using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Common
{
    public class MarkNotesReadViewModel
    {
        public int EmployeeId { get; set; }
        public Int32[] NoteIds { get; set; }
        public bool Read { get; set; }
    }
}
