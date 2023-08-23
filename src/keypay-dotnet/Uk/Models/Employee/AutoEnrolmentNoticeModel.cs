using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class AutoEnrolmentNoticeModel
    {
        public int? Id { get; set; }
        public DateTime? NoticeSentDate { get; set; }
        public DateTime? EnrolledDate { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PensionAssessmentStatusEnum AssessmentStatus { get; set; }
        public string DownloadUrl { get; set; }
        public string EmailUrl { get; set; }
        public DateTime? EnrolmentDeferralDate { get; set; }
    }
}
