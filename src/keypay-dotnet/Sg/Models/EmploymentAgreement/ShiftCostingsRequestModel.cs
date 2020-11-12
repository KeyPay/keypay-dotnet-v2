using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.EmploymentAgreement
{
    public class ShiftCostingsRequestModel
    {
        public string TransactionExternalId { get; set; }
        public IdType LocationIdType { get; set; }
        public IdType WorkTypeIdType { get; set; }
        public bool IncludeEvaluationResults { get; set; }
        public ShiftCostingsEmployeeModel Employee { get; set; }
        public IList<ShiftCostingsRequestShiftModel> Shifts { get; set; }
    }
}
