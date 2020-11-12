using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Ess
{
    public class EmployeeEmergencyContactsEditModel
    {
        public EmergencyContactEditModel PrimaryEmergencyContact { get; set; }
        public EmergencyContactEditModel SecondaryEmergencyContact { get; set; }
        public bool CanEdit { get; set; }
    }
}
