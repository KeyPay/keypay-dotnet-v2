using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class P11dFormsUrls
    {
        public string Load { get; set; }
        public string Publish { get; set; }
        public string Unpublish { get; set; }
        public string Notify { get; set; }
        public string PublishAll { get; set; }
        public string UnpublishAll { get; set; }
        public string NotifyAll { get; set; }
        public string Submit { get; set; }
        public string HaveAllEmployeeP11dsBeenPublished { get; set; }
        public string HaveEmployeeP11dsBeenSubmitted { get; set; }
        public string DownloadAll { get; set; }
        public string DownloadFile { get; set; }
    }
}
