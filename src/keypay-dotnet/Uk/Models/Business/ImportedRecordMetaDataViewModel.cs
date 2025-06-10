using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Business
{
    public class ImportedRecordMetaDataViewModel
    {
        public string PageUrlText { get; set; }
        public string PageUrl { get; set; }
        public string Description { get; set; }
    }
}
