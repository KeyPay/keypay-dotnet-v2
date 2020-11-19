using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.EmploymentAgreement
{
    public class BasicEmploymentAgreementModel
    {
        public int Id { get; set; }
        public string Classification { get; set; }
        public EmploymentTypeEnum EmploymentType { get; set; }
        public string Name { get; set; }
        public string AwardName { get; set; }
        public int Rank { get; set; }
    }
}
