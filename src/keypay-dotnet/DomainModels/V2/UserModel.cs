namespace KeyPay.DomainModels.V2
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public string TimeZone { get; set; }
    }

    public class CreateUserModel : BaseUserModel
    {
        public bool ApiOnly { get; set; }
    }

    public abstract class BaseUserModel
    {
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string TimeZone { get; set; }
    }

    public class CreatedUserModel : BaseUserModel
    {
        public string ApiKey { get; set; }
    }
}