using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Other
{
    public class GetPaymentFilesByFinalisedPayRunIdQueryModel
    {
        public int PayRunId { get; set; }
        public int? PaymentFileId { get; set; }
    }
}
