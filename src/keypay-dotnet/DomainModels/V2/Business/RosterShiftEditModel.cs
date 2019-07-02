using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyPay.DomainModels.V2.Business
{
    public class RosterShiftEditModel
    {
        public int? EmployeeId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int LocationId { get; set; }
        public int? ResourceId { get; set; }
        public int? CopyId { get; set; }
    }
}
