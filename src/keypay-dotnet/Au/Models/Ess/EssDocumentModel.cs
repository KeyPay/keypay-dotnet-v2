using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Ess
{
    public class EssDocumentModel
    {
        public string Id { get; set; }
        public string FriendlyName { get; set; }
        public DateTime DateCreated { get; set; }
        public bool RequiresEmployeeAcknowledgement { get; set; }
        public DateTime? DateAcknowledged { get; set; }
    }
}
