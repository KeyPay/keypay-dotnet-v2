using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Ess
{
    public class EssAcnowledgeDocumentModel
    {
        public EssDocumentModel Document { get; set; }
        public int DocumentsRequiringAcknowledgementCount { get; set; }
    }
}
