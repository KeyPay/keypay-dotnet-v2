using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Other
{
    public class GetPaymentFilesByFinalisedPayRunIdQueryModel
    {
        public int PayRunId { get; set; }
        public int? PaymentFileId { get; set; }
    }
}
