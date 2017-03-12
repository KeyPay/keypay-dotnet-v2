namespace KeyPay.DomainModels.V2
{
    public class DocumentFile
    {
        public long ContentLength { get; set; }
        public string ContentType { get; set; }
        public byte[] Bytes { get; set; }
        public string Filename { get; set; }
    }
}