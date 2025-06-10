using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Ess
{
    public class EmployeeDetailsFields
    {
        public bool ShowStartDate { get; set; }
        public bool ShowTitle { get; set; }
        public bool ShowPreferredName { get; set; }
        public bool ShowPreviousSurname { get; set; }
        public bool ShowGender { get; set; }
        public bool ShowDateOfBirth { get; set; }
        public bool ShowAnniversaryDate { get; set; }
        public bool ShowPostalAddress { get; set; }
        public bool IsNameMandatory { get; set; }
        public bool IsAddressMandatory { get; set; }
    }
}
