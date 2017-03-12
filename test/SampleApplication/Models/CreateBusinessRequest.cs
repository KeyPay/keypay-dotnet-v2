using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApplication.Models
{
    public class CreateBusinessRequest
    {
        public string BusinessName { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ABN { get; set; }
        public decimal StandardHoursPerDay { get; set; }
        public List<int> PaySheduleFrequencyIds { get; set; }
    }
}
