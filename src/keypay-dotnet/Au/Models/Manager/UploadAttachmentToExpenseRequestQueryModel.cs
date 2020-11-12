using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Manager
{
    public class UploadAttachmentToExpenseRequestQueryModel
    {
        public string FileName { get; set; }
    }
}
