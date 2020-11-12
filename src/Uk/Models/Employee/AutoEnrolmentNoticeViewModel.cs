using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class AutoEnrolmentNoticeViewModel
    {
        public bool HasNotice { get; set; }
        public PensionAssessmentStatusEnum? CurrentAssessmentStatus { get; set; }
        public DateTime? AssessmentDate { get; set; }
        public IList<AutoEnrolmentNoticeModel> AutoEnrolmentNotices { get; set; }
        public Int32[] ValidPensionAssessmentStatusTypes { get; set; }
        public DateTime? NoticeSentDate { get; set; }
        public string DownloadUrl { get; set; }
        public bool HasPensionSchemeContributionPlan { get; set; }
        public DateTime? DeferralDate { get; set; }
    }
}
