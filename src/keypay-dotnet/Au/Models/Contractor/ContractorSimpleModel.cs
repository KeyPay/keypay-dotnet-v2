using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Contractor
{
    public class ContractorSimpleModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string TradingName { get; set; }
        public string Abn { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime? StartDate { get; set; }
    }
}
