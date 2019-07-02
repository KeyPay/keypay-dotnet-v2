using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyPay.DomainModels.V2
{
    public class UnavailabilityModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Reason { get; set; }
        public bool Recurring { get; set; }
        public DayOfWeek? RecurringDay { get; set; }
        public virtual bool IsAllDay { get; set; }
        public bool ViewOnly { get; set; }
    }
}
