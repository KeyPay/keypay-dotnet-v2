using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;
using MidpointRounding = KeyPayV2.Uk.Enums.MidpointRounding;

namespace KeyPayV2.Uk.Models.EmploymentAgreement
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
