using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Employee
{
    public class EmployeeNoteModel
    {
        public int Id { get; set; }
        public string User { get; set; }
        public DateTime DateTime { get; set; }
        public string Note { get; set; }
    }
}
