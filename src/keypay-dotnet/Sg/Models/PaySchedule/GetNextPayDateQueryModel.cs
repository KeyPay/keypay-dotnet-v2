using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.PaySchedule
{
    public class GetNextPayDateQueryModel
    {
        public bool UseInitialPayRunCreationDateTime { get; set; }
    }
}
