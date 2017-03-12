namespace KeyPay.DomainModels.V2
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public string TimeZone { get; set; }
    }
}