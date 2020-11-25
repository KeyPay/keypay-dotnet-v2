using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.EmployeeQualifications
{
    public class EmployeeQualificationDocumentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Visible { get; set; }
    }
}
