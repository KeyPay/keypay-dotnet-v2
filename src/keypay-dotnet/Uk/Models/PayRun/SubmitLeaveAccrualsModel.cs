using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PayRun
{
    public class SubmitLeaveAccrualsModel
    {
        public bool ReplaceExisting { get; set; }
        public IdType EmployeeIdType { get; set; }
        public bool SuppressCalculations { get; set; }
        public Dictionary<string,List<SaveLeaveAccrualModel>> Leave { get; set; }
    }
}
