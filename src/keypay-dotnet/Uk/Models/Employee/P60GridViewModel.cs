using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class P60GridViewModel
    {
        public int Id { get; set; }
        public int FinancialYearEnding { get; set; }
        public string DownloadUrl { get; set; }
        public P60Status Status { get; set; }
        public DateTime DateGenerated { get; set; }
        public DateTime? NotificationDate { get; set; }
        public string Text { get; set; }
    }
}
