﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KeyPayV2.Uk.Models.Business;

namespace SampleApplication.Models
{
    public class CreateBusinessRequest:CreateNewBusinessQueryModel
    {
        public string BusinessName { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string Chrn { get; set; }
        public decimal StandardHoursPerDay { get; set; }
        public List<int> PaySheduleFrequencyIds { get; set; }
    }
}
