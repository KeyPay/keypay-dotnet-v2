using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Other
{
    public class GetPaymentFilesByFinalisedPayRunIdQueryModel
    {
        public int PayRunId { get; set; }
        public int? PaymentFileId { get; set; }
    }
}
