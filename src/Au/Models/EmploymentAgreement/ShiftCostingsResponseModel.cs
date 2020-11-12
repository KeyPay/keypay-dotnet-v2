using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.EmploymentAgreement
{
    public class ShiftCostingsResponseModel
    {
        public Guid TransactionId { get; set; }
        public string TransactionExternalId { get; set; }
        public int EmploymentAgreementId { get; set; }
        public string EmploymentAgreementName { get; set; }
        public int PayConditionRuleSetId { get; set; }
        public string PayConditionRuleSetName { get; set; }
        public List<ShiftCostingsResponseShiftModel> Shifts { get; set; }
    }
}
