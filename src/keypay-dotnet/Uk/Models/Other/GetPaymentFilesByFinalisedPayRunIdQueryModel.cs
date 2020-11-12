using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Other
{
    public class GetPaymentFilesByFinalisedPayRunIdQueryModel
    {
        public int PayRunId { get; set; }
        public int? PaymentFileId { get; set; }
    }
}
