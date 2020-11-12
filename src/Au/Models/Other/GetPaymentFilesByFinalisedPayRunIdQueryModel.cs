using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Other
{
    public class GetPaymentFilesByFinalisedPayRunIdQueryModel
    {
        public int PayRunId { get; set; }
        public int? PaymentFileId { get; set; }
    }
}
