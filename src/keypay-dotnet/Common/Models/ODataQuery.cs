using System.Text;

namespace KeyPayV2.Common.Models
{
    public class ODataQuery
    {
        public string Filter { get; set; }
        public string OrderBy { get; set; }
        public int? Top { get; set; }
        public int? Skip { get; set; }

        public static string ToQueryString(ODataQuery data, string prefix)
        {
            if (data == null || data.NoValues())
            {
                return string.Empty;
            }

            var addedToQueryString = false;
            var sb = new StringBuilder(prefix);
            if (!string.IsNullOrEmpty(data.Filter))
            {
                sb.Append($"$filter={data.Filter}");
                addedToQueryString = true;
            }
            if (!string.IsNullOrEmpty(data.OrderBy))
            {
                sb.Append($"{(addedToQueryString ? "&" : "")}$orderby={data.OrderBy}");
                addedToQueryString = true;
            }
            if (data.Top.HasValue)
            {
                sb.Append($"{(addedToQueryString ? "&" : "")}$top={data.Top.Value}");
                addedToQueryString = true;
            }
            if (data.Skip.HasValue)
            {
                sb.Append($"{(addedToQueryString ? "&" : "")}$skip={data.Skip.Value}");
            }
            return sb.ToString();
        }

        private bool NoValues()
        {
            return string.IsNullOrEmpty(Filter) && string.IsNullOrEmpty(OrderBy) && !Top.HasValue && !Skip.HasValue;
        }
    }
}