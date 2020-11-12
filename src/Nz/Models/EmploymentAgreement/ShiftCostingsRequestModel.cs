using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.EmploymentAgreement
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
