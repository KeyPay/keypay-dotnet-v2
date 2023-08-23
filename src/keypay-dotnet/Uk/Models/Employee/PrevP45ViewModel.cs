using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class PrevP45ViewModel
    {
        public bool Exists { get; set; }
        public DateTime? UploadDate { get; set; }
        public string P45Url { get; set; }
    }
}
