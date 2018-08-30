using KeyPay.DomainModels.V2;
using RestSharp;

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

        public CreatedUserModel Create(CreateUserModel user)
        {
            var model = ApiRequest<CreatedUserModel, CreateUserModel>("/user", user, Method.POST);
            return model;
        }


    }
}