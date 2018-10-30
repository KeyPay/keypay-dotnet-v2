using System;

namespace KeyPay.DomainModels.V2.Business
{
    public class BusinessModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ABN { get; set; }
        public string LegalName { get; set; }
        public string ContactName { get; set; }
        public string ContactEmailAddress { get; set; }
        public string ContactPhoneNumber { get; set; }
        public string ContactFaxNumber { get; set; }
        public string ExternalId { get; set; }
        public decimal StandardHoursPerDay { get; set; }
        public string JournalService { get; set; }
        public DayOfWeek EndOfWeek { get; set; }
        public int? InitialFinancialYearStart { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Suburb { get; set; }
        public string PostCode { get; set; }
        public string State { get; set; }
        public string WhiteLabelName { get; set; }
        public DateTime DateCreated { get; set; }
        public string PromoCode { get; set; }
        public string ManagementSoftwareId { get; set; }
        public string SbrSoftwareProvider { get; set; }
        public string SbrSoftwareId { get; set; }
    }
}