using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Nz.Enums;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Models.User;

namespace KeyPayV2.Nz.Functions
{
    public interface IUserFunction
    {
        UserModel GetUserDetails();
        Task<UserModel> GetUserDetailsAsync(CancellationToken cancellationToken = default);
        UserUpdatedModel UpdateUser(UpdateUserModel model);
        Task<UserUpdatedModel> UpdateUserAsync(UpdateUserModel model, CancellationToken cancellationToken = default);
        NewUserCreatedModel CreateNewUser(NewUserModel model);
        Task<NewUserCreatedModel> CreateNewUserAsync(NewUserModel model, CancellationToken cancellationToken = default);
        RelatedBusinessesModel ListRelatedBusinessesForTheProvidedUser();
        Task<RelatedBusinessesModel> ListRelatedBusinessesForTheProvidedUserAsync(CancellationToken cancellationToken = default);
        RelatedBusinessesModel ListRelatedBusinessesForTheProvidedUser(ListRelatedBusinessesForTheProvidedUserQueryModel request);
        Task<RelatedBusinessesModel> ListRelatedBusinessesForTheProvidedUserAsync(ListRelatedBusinessesForTheProvidedUserQueryModel request, CancellationToken cancellationToken = default);
        UserAccountMetadataLite ListRelatedBusinessesAndEmployeesButJustTheIdsAndTheirBrandidsAndPartnerids();
        Task<UserAccountMetadataLite> ListRelatedBusinessesAndEmployeesButJustTheIdsAndTheirBrandidsAndPartneridsAsync(CancellationToken cancellationToken = default);
        UserAccountMetadataLite ListRelatedBusinessesAndEmployeesButJustTheIdsAndTheirBrandidsAndPartnerids(ListRelatedBusinessesAndEmployeesButJustTheIdsAndTheirBrandidsAndPartneridsQueryModel request);
        Task<UserAccountMetadataLite> ListRelatedBusinessesAndEmployeesButJustTheIdsAndTheirBrandidsAndPartneridsAsync(ListRelatedBusinessesAndEmployeesButJustTheIdsAndTheirBrandidsAndPartneridsQueryModel request, CancellationToken cancellationToken = default);
        NzUserAccountPartnerMetadata ListRelatedPartners();
        Task<NzUserAccountPartnerMetadata> ListRelatedPartnersAsync(CancellationToken cancellationToken = default);
        NzUserAccountPartnerMetadata ListRelatedPartners(ListRelatedPartnersQueryModel request);
        Task<NzUserAccountPartnerMetadata> ListRelatedPartnersAsync(ListRelatedPartnersQueryModel request, CancellationToken cancellationToken = default);
    }
    public class UserFunction : BaseFunction, IUserFunction
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
            return ApiRequest<UserModel>($"/user", Method.Get);
        }

        /// <summary>
        /// Get User Details
        /// </summary>
        /// <remarks>
        /// Gets details about the user.
        /// </remarks>
        public Task<UserModel> GetUserDetailsAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UserModel>($"/user", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update User
        /// </summary>
        /// <remarks>
        /// This is currently restricted to updating the user's "email confirmation" status only.
        /// The API user (brand manager or reseller) must have brand exclusive access to the user
        /// i.e. the user must only have access to businesses/employees that the API user manages.
        /// </remarks>
        public UserUpdatedModel UpdateUser(UpdateUserModel model)
        {
            return ApiRequest<UserUpdatedModel,UpdateUserModel>($"/user", model, Method.Put);
        }

        /// <summary>
        /// Update User
        /// </summary>
        /// <remarks>
        /// This is currently restricted to updating the user's "email confirmation" status only.
        /// The API user (brand manager or reseller) must have brand exclusive access to the user
        /// i.e. the user must only have access to businesses/employees that the API user manages.
        /// </remarks>
        public Task<UserUpdatedModel> UpdateUserAsync(UpdateUserModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UserUpdatedModel,UpdateUserModel>($"/user", model, Method.Put, cancellationToken);
        }

        /// <summary>
        /// Create New User
        /// </summary>
        /// <remarks>
        /// Creates a new user and sends an email to inform the user.
        /// In order to make sure that the correct brand details are included in the email, be sure to `POST` the API request to `https://{yourbrand}.yourpayroll.com.au`.<br />
        /// To prevent sending of the new user email, set `apiOnly` to `true` in the request.
        /// </remarks>
        public NewUserCreatedModel CreateNewUser(NewUserModel model)
        {
            return ApiRequest<NewUserCreatedModel,NewUserModel>($"/user", model, Method.Post);
        }

        /// <summary>
        /// Create New User
        /// </summary>
        /// <remarks>
        /// Creates a new user and sends an email to inform the user.
        /// In order to make sure that the correct brand details are included in the email, be sure to `POST` the API request to `https://{yourbrand}.yourpayroll.com.au`.<br />
        /// To prevent sending of the new user email, set `apiOnly` to `true` in the request.
        /// </remarks>
        public Task<NewUserCreatedModel> CreateNewUserAsync(NewUserModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NewUserCreatedModel,NewUserModel>($"/user", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// List Related Businesses for the provided user.
        /// </summary>
        /// <remarks>
        /// List Related Businesses for the provided user. This is an Admin only function
        /// </remarks>
        public RelatedBusinessesModel ListRelatedBusinessesForTheProvidedUser()
        {
            return ApiRequest<RelatedBusinessesModel>($"/user/account/businesses", Method.Get);
        }

        /// <summary>
        /// List Related Businesses for the provided user.
        /// </summary>
        /// <remarks>
        /// List Related Businesses for the provided user. This is an Admin only function
        /// </remarks>
        public Task<RelatedBusinessesModel> ListRelatedBusinessesForTheProvidedUserAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<RelatedBusinessesModel>($"/user/account/businesses", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Related Businesses for the provided user.
        /// </summary>
        /// <remarks>
        /// List Related Businesses for the provided user. This is an Admin only function
        /// </remarks>
        public RelatedBusinessesModel ListRelatedBusinessesForTheProvidedUser(ListRelatedBusinessesForTheProvidedUserQueryModel request)
        {
            return ApiRequest<RelatedBusinessesModel>($"/user/account/businesses?username={request.Username}", Method.Get);
        }

        /// <summary>
        /// List Related Businesses for the provided user.
        /// </summary>
        /// <remarks>
        /// List Related Businesses for the provided user. This is an Admin only function
        /// </remarks>
        public Task<RelatedBusinessesModel> ListRelatedBusinessesForTheProvidedUserAsync(ListRelatedBusinessesForTheProvidedUserQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<RelatedBusinessesModel>($"/user/account/businesses?username={request.Username}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Related Businesses And Employees, but just the IDs and their BrandIds and PartnerIds
        /// </summary>
        /// <remarks>
        /// List account information with businesses and employees linked to user. Just includes EmployeeIds, BusinessIds, and BrandIds, and PartnerIds.
        /// This is a bespoke end point written for the eBenefits team in EH. It is not intended for general use.
        /// </remarks>
        public UserAccountMetadataLite ListRelatedBusinessesAndEmployeesButJustTheIdsAndTheirBrandidsAndPartnerids()
        {
            return ApiRequest<UserAccountMetadataLite>($"/user/account/metadatalite", Method.Get);
        }

        /// <summary>
        /// List Related Businesses And Employees, but just the IDs and their BrandIds and PartnerIds
        /// </summary>
        /// <remarks>
        /// List account information with businesses and employees linked to user. Just includes EmployeeIds, BusinessIds, and BrandIds, and PartnerIds.
        /// This is a bespoke end point written for the eBenefits team in EH. It is not intended for general use.
        /// </remarks>
        public Task<UserAccountMetadataLite> ListRelatedBusinessesAndEmployeesButJustTheIdsAndTheirBrandidsAndPartneridsAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UserAccountMetadataLite>($"/user/account/metadatalite", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Related Businesses And Employees, but just the IDs and their BrandIds and PartnerIds
        /// </summary>
        /// <remarks>
        /// List account information with businesses and employees linked to user. Just includes EmployeeIds, BusinessIds, and BrandIds, and PartnerIds.
        /// This is a bespoke end point written for the eBenefits team in EH. It is not intended for general use.
        /// </remarks>
        public UserAccountMetadataLite ListRelatedBusinessesAndEmployeesButJustTheIdsAndTheirBrandidsAndPartnerids(ListRelatedBusinessesAndEmployeesButJustTheIdsAndTheirBrandidsAndPartneridsQueryModel request)
        {
            return ApiRequest<UserAccountMetadataLite>($"/user/account/metadatalite?username={request.Username}", Method.Get);
        }

        /// <summary>
        /// List Related Businesses And Employees, but just the IDs and their BrandIds and PartnerIds
        /// </summary>
        /// <remarks>
        /// List account information with businesses and employees linked to user. Just includes EmployeeIds, BusinessIds, and BrandIds, and PartnerIds.
        /// This is a bespoke end point written for the eBenefits team in EH. It is not intended for general use.
        /// </remarks>
        public Task<UserAccountMetadataLite> ListRelatedBusinessesAndEmployeesButJustTheIdsAndTheirBrandidsAndPartneridsAsync(ListRelatedBusinessesAndEmployeesButJustTheIdsAndTheirBrandidsAndPartneridsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UserAccountMetadataLite>($"/user/account/metadatalite?username={request.Username}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Related Partners
        /// </summary>
        /// <remarks>
        /// List related partner IDs that are associated to the businesses and employees linked to user.
        /// </remarks>
        public NzUserAccountPartnerMetadata ListRelatedPartners()
        {
            return ApiRequest<NzUserAccountPartnerMetadata>($"/user/account/partner/metadata", Method.Get);
        }

        /// <summary>
        /// List Related Partners
        /// </summary>
        /// <remarks>
        /// List related partner IDs that are associated to the businesses and employees linked to user.
        /// </remarks>
        public Task<NzUserAccountPartnerMetadata> ListRelatedPartnersAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzUserAccountPartnerMetadata>($"/user/account/partner/metadata", Method.Get, cancellationToken);
        }

        /// <summary>
        /// List Related Partners
        /// </summary>
        /// <remarks>
        /// List related partner IDs that are associated to the businesses and employees linked to user.
        /// </remarks>
        public NzUserAccountPartnerMetadata ListRelatedPartners(ListRelatedPartnersQueryModel request)
        {
            return ApiRequest<NzUserAccountPartnerMetadata>($"/user/account/partner/metadata?username={request.Username}", Method.Get);
        }

        /// <summary>
        /// List Related Partners
        /// </summary>
        /// <remarks>
        /// List related partner IDs that are associated to the businesses and employees linked to user.
        /// </remarks>
        public Task<NzUserAccountPartnerMetadata> ListRelatedPartnersAsync(ListRelatedPartnersQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<NzUserAccountPartnerMetadata>($"/user/account/partner/metadata?username={request.Username}", Method.Get, cancellationToken);
        }
    }
}
