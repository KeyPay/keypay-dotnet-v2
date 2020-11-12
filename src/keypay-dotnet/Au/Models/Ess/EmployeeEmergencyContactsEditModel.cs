using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Ess
{
    public class EmployeeEmergencyContactsEditModel
    {
        public EmergencyContactEditModel PrimaryEmergencyContact { get; set; }
        public EmergencyContactEditModel SecondaryEmergencyContact { get; set; }
        public bool CanEdit { get; set; }
    }
}
