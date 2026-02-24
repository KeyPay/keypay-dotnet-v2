using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Ess
{
    public class EssAcnowledgeDocumentModel
    {
        public EssDocumentModel Document { get; set; }
        public int DocumentsRequiringAcknowledgementCount { get; set; }
    }
}
