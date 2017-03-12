namespace KeyPay.DomainModels.V2
{
    public class FileUploadModel
    {
        public string FileName { get; set; }
        public byte[] File { get; set; }
    }
}