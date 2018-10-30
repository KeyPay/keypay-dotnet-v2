using System.Collections.Generic;

namespace KeyPay.DomainModels.V2
{
    public class PagedResultModel<T>
    {
        public int CurrentPage { get; set; }
        public int ItemCount { get; set; }
        public int PageSize { get; set; }
        public int PageCount { get; set; }
        public IEnumerable<T> Items { get; set; }
    }
}
