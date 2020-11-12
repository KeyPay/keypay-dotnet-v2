using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Business
{
    public class CreateBusinessDocumentQueryModel
    {
        public bool VisibleToAll { get; set; }
    }
}
