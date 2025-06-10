using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Common
{
    public class InitiateEmployeeOnboardingApiModel
    {
        public int? Id { get; set; }
        public int? Title { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public bool QualificationsRequired { get; set; }
        public bool EmergencyContactDetailsRequired { get; set; }
    }
}
