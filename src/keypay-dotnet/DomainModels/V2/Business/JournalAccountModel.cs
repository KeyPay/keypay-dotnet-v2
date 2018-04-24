using KeyPay.Enums;

namespace KeyPay.DomainModels.V2.Business
{
    public class JournalAccountModel
    {
        public int Id { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public ExternalAccountType AccountType { get; set; }
        public string ExternalReferenceId { get; set; }
    }
}