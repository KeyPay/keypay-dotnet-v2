namespace KeyPay.DomainModels.V2.Business
{
    public class BusinessModel
    {
        public int Id { get; set; }
            public string Name { get; set; }
            public string Abn { get; set; }
            public string LegalName { get; set; }
            public string ContactName { get; set; }
            public string ContactEmailAddress { get; set; }
            public string ContactPhoneNumber { get; set; }
            public string ExternalId { get; set; }
            public decimal StandardHoursPerDay { get; set; }
        public bool IntegratedTimesheetsEnabled { get; set; }
        public string JournalService { get; set; }
        public int? InitialFinancialYearStart { get; set; }
    }
}