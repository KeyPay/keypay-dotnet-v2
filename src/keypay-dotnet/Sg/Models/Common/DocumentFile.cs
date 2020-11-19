using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Common
{
    public class DocumentFile
    {
        public int ContentLength { get; set; }
        public string ContentType { get; set; }
        public Byte[] Bytes { get; set; }
        public string Filename { get; set; }
    }
}
