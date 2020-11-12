using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Common
{
    public class MarkNotesReadViewModel
    {
        public int EmployeeId { get; set; }
        public Int32[] NoteIds { get; set; }
        public bool Read { get; set; }
    }
}
