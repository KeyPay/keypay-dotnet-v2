using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Business
{
    public class CreateBusinessDocumentQueryModel
    {
        public bool VisibleToAll { get; set; }
    }
}
