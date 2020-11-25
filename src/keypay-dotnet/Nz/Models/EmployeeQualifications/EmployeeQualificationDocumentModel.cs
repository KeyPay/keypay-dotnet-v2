using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;
using MidpointRounding = KeyPayV2.Nz.Enums.MidpointRounding;

namespace KeyPayV2.Nz.Models.EmployeeQualifications
{
    public class EmployeeQualificationDocumentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Visible { get; set; }
    }
}
