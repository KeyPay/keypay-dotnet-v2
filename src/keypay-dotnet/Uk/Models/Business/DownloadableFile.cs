using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Business
{
    public class DownloadableFile
    {
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public Byte[] FileContent { get; set; }
        public string TempFileKey { get; set; }
        public List<String> ErrorMessages { get; set; }
    }
}
