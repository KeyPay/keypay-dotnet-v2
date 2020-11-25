using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;
using MidpointRounding = KeyPayV2.Sg.Enums.MidpointRounding;

namespace KeyPayV2.Sg.Models.Ess
{
    public class EmployeeEmergencyContactsEditModel
    {
        public EmergencyContactEditModel PrimaryEmergencyContact { get; set; }
        public EmergencyContactEditModel SecondaryEmergencyContact { get; set; }
        public bool CanEdit { get; set; }
    }
}
