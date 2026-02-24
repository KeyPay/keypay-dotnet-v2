using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Ess
{
    public class EssAcnowledgeDocumentModel
    {
        public EssDocumentModel Document { get; set; }
        public int DocumentsRequiringAcknowledgementCount { get; set; }
    }
}
