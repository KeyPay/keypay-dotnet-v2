using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Common
{
    public class NzInitiateEmployeeOnboardingApiModel
    {
        public int? EmployingEntityId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public OnboardingStarterTypeEnum? OnboardingStarterType { get; set; }
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
