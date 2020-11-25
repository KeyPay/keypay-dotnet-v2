using System.Collections.Generic;

namespace KeyPayV2.Common.Models
{
    public class PagedResultModel<T>
    {
        public int ItemCount { get; set; }
        public List<T> Items { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int PageCount { get; set; }
    }
}