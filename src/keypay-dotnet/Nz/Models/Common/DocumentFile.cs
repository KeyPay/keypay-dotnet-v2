using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.Common
{
    public class DocumentFile
    {
        public long ContentLength { get; set; }
        public string ContentType { get; set; }
        public Byte[] Bytes { get; set; }
        public string Filename { get; set; }
    }
}
