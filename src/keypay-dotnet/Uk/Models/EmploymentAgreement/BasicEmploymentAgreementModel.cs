using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.EmploymentAgreement
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
