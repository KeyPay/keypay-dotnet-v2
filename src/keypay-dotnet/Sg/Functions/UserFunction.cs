using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Sg.Enums;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Models.User;

namespace KeyPayV2.Sg.Functions
{
    public class UserFunction : BaseFunction
    {
        public UserFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get User Details
        /// </summary>
        /// <remarks>
        /// Gets details about the user.
        /// </remarks>
        public UserModel GetUserDetails()
        {
            return ApiRequest<UserModel>($"/user", Method.GET);
        }

        /// <summary>
        /// Get User Details
        /// </summary>
        /// <remarks>
        /// Gets details about the user.
        /// </remarks>
        public Task<UserModel> GetUserDetailsAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UserModel>($"/user", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create New User
        /// </summary>
        /// <remarks>
        /// Creates a new user.
        /// </remarks>
        public NewUserCreatedModel CreateNewUser(NewUserModel model)
        {
            return ApiRequest<NewUserCreatedModel,NewUserModel>($"/user", model, Method.POST);
        }

        /// <summary>
        /// Create New User
        /// </summary>
        /// <remarks>
        /// Creates a new user.
        /// </remarks>
        public Task<NewUserCreatedModel> CreateNewUserAsync(NewUserModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NewUserCreatedModel,NewUserModel>($"/user", model, Method.POST, cancellationToken);
        }
    }
}
