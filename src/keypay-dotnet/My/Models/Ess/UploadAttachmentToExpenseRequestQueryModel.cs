using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Ess
{
    public class UploadAttachmentToExpenseRequestQueryModel
    {
        public string FileName { get; set; }
    }
}
