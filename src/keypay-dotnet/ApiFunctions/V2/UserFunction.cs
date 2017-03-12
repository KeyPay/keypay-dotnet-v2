using KeyPay.DomainModels.V2;

namespace KeyPay.ApiFunctions.V2
{
    public class UserFunction : BaseFunction
    {
        public UserFunction(ApiRequestExecutor api)
            : base(api)
        {
        }

        public UserModel Get()
        {
            var model = ApiRequest<UserModel>("/user");
            return model;
        }
    }
}