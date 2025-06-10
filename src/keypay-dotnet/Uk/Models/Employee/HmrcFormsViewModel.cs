using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class HmrcFormsViewModel
    {
        public IList<P60GridViewModel> P60s { get; set; }
        public IList<P11dGridViewModel> P11ds { get; set; }
        public bool HasP45 { get; set; }
        public P45ViewModel P45 { get; set; }
        public PrevP45ViewModel PrevP45 { get; set; }
        public bool HasP60s { get; set; }
        public bool HasP11ds { get; set; }
        public AutoEnrolmentNoticeViewModel AutoEnrolmentData { get; set; }
        public P60ViewModel P60 { get; set; }
        public P11dFormsUrls Urls { get; set; }
        public NationalInsuranceBackCalculationViewModel NationalInsuranceBackCalculation { get; set; }
        public bool HasNationalInsuranceBackCalculation { get; set; }
        public List<HmrcNoticeModel> HmrcNotices { get; set; }
    }
}
