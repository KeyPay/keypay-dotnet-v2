namespace KeyPay.DomainModels.V2.PayRun
{
    public class LocationEditModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ExternalReferenceId { get; set; }
       // public ExternalService Source { get; set; }
        public int? ParentId { get; set; }
        public string FullyQualifiedName { get; set; }
    }
}