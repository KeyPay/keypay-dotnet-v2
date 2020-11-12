using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Webhook
{
    public class WebHook
    {
        public string Id { get; set; }
        public Uri WebHookUri { get; set; }
        public string Secret { get; set; }
        public string Description { get; set; }
        public bool IsPaused { get; set; }
        public ISet<String> Filters { get; set; }
        public IDictionary<String,String> Headers { get; set; }
        public IDictionary<String,Object> Properties { get; set; }
    }
}
