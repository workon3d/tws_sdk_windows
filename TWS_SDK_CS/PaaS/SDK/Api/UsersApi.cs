using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using PaaS.SDK.Client;
using PaaS.SDK.Model;

namespace PaaS.SDK.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUsersApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Activates a user
        /// </summary>
        /// <remarks>
        /// Activates a user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">json to activate a user</param>
        /// <returns>UserAuthenticated</returns>
        UserAuthenticated ActivateUser (ActivateUserOptions jSONBody);
  
        /// <summary>
        /// Activates a user
        /// </summary>
        /// <remarks>
        /// Activates a user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">json to activate a user</param>
        /// <returns>ApiResponse of UserAuthenticated</returns>
        ApiResponse<UserAuthenticated> ActivateUserWithHttpInfo (ActivateUserOptions jSONBody);
        
        /// <summary>
        /// Authenticates a user
        /// </summary>
        /// <remarks>
        /// Authenticates a user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">json to authenticate a user</param>
        /// <returns>UserAuthenticated</returns>
        UserAuthenticated AuthenticateUser (AuthenticateUserOptions jSONBody);
  
        /// <summary>
        /// Authenticates a user
        /// </summary>
        /// <remarks>
        /// Authenticates a user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">json to authenticate a user</param>
        /// <returns>ApiResponse of UserAuthenticated</returns>
        ApiResponse<UserAuthenticated> AuthenticateUserWithHttpInfo (AuthenticateUserOptions jSONBody);
        
        /// <summary>
        /// Change user&#39;s password
        /// </summary>
        /// <remarks>
        /// Change user&#39;s password
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">json to change user&#39;s password. New password and password_token are needed.</param>
        /// <returns></returns>
        void ChangePassword (PasswordOptions jSONBody);
  
        /// <summary>
        /// Change user&#39;s password
        /// </summary>
        /// <remarks>
        /// Change user&#39;s password
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">json to change user&#39;s password. New password and password_token are needed.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ChangePasswordWithHttpInfo (PasswordOptions jSONBody);
        
        /// <summary>
        /// Creates a new address of user
        /// </summary>
        /// <remarks>
        /// Creates a new address of user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Address json to create a address</param>
        /// <returns>Address</returns>
        Address CreateAddress (Address jSONBody);
  
        /// <summary>
        /// Creates a new address of user
        /// </summary>
        /// <remarks>
        /// Creates a new address of user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Address json to create a address</param>
        /// <returns>ApiResponse of Address</returns>
        ApiResponse<Address> CreateAddressWithHttpInfo (Address jSONBody);
        
        /// <summary>
        /// Creates a new credit card of user
        /// </summary>
        /// <remarks>
        /// Creates a new credit card of user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Address json to create a credit card. cc_id is not used.</param>
        /// <returns>Address</returns>
        Address CreateCreditcard (CreditCard jSONBody);
  
        /// <summary>
        /// Creates a new credit card of user
        /// </summary>
        /// <remarks>
        /// Creates a new credit card of user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Address json to create a credit card. cc_id is not used.</param>
        /// <returns>ApiResponse of Address</returns>
        ApiResponse<Address> CreateCreditcardWithHttpInfo (CreditCard jSONBody);
        
        /// <summary>
        /// Creates a new user
        /// </summary>
        /// <remarks>
        /// Creates a new user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">User json to create a new user</param>
        /// <param name="activationRequired">Additional activation is necessary to enable the created user (optional, default to false)</param>
        /// <returns>User</returns>
        User CreateUser (CreateUserOptions jSONBody, bool? activationRequired = null);
  
        /// <summary>
        /// Creates a new user
        /// </summary>
        /// <remarks>
        /// Creates a new user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">User json to create a new user</param>
        /// <param name="activationRequired">Additional activation is necessary to enable the created user (optional, default to false)</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> CreateUserWithHttpInfo (CreateUserOptions jSONBody, bool? activationRequired = null);
        
        /// <summary>
        /// Get addresses of user
        /// </summary>
        /// <remarks>
        /// Get addresses of user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param>
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param>
        /// <returns>Addresses</returns>
        Addresses GetAddress (int? page = null, int? perPage = null);
  
        /// <summary>
        /// Get addresses of user
        /// </summary>
        /// <remarks>
        /// Get addresses of user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param>
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param>
        /// <returns>ApiResponse of Addresses</returns>
        ApiResponse<Addresses> GetAddressWithHttpInfo (int? page = null, int? perPage = null);
        
        /// <summary>
        /// Get credit cards of user
        /// </summary>
        /// <remarks>
        /// Get credit cards of user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param>
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param>
        /// <returns>CreditCards</returns>
        CreditCards GetCreditcards (int? page = null, int? perPage = null);
  
        /// <summary>
        /// Get credit cards of user
        /// </summary>
        /// <remarks>
        /// Get credit cards of user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param>
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param>
        /// <returns>ApiResponse of CreditCards</returns>
        ApiResponse<CreditCards> GetCreditcardsWithHttpInfo (int? page = null, int? perPage = null);
        
        /// <summary>
        /// Get the token to change user&#39;s password
        /// </summary>
        /// <remarks>
        /// Get the token to change user&#39;s password
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">json to get the token for changing user&#39;s password. The original password should be offered.</param>
        /// <returns>PasswordToken</returns>
        PasswordToken GetPasswordToken (PasswordTokenOptions jSONBody);
  
        /// <summary>
        /// Get the token to change user&#39;s password
        /// </summary>
        /// <remarks>
        /// Get the token to change user&#39;s password
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">json to get the token for changing user&#39;s password. The original password should be offered.</param>
        /// <returns>ApiResponse of PasswordToken</returns>
        ApiResponse<PasswordToken> GetPasswordTokenWithHttpInfo (PasswordTokenOptions jSONBody);
        
        /// <summary>
        /// Get a user
        /// </summary>
        /// <remarks>
        /// Get a user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>User</returns>
        User GetUser (string userId);
  
        /// <summary>
        /// Get a user
        /// </summary>
        /// <remarks>
        /// Get a user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> GetUserWithHttpInfo (string userId);
        
        /// <summary>
        /// Get options to create/update user
        /// </summary>
        /// <remarks>
        /// Get options to create/update user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UserOptions</returns>
        UserOptions OptionsUser ();
  
        /// <summary>
        /// Get options to create/update user
        /// </summary>
        /// <remarks>
        /// Get options to create/update user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UserOptions</returns>
        ApiResponse<UserOptions> OptionsUserWithHttpInfo ();
        
        /// <summary>
        /// Request to send the activation mail to user
        /// </summary>
        /// <remarks>
        /// Request to send the activation mail to user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">user email who wants to get the activation mail</param>
        /// <param name="hostUrl">front-end host URL to be used in the link on the activation mail</param>
        /// <returns></returns>
        void RequestActivationUser (string email, string hostUrl);
  
        /// <summary>
        /// Request to send the activation mail to user
        /// </summary>
        /// <remarks>
        /// Request to send the activation mail to user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">user email who wants to get the activation mail</param>
        /// <param name="hostUrl">front-end host URL to be used in the link on the activation mail</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RequestActivationUserWithHttpInfo (string email, string hostUrl);
        
        /// <summary>
        /// Request to send the reset password mail to user
        /// </summary>
        /// <remarks>
        /// Request to send the reset password mail to user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">user email who wants to get the reset password mail</param>
        /// <param name="hostUrl">front-end host URL to be used in the link on the reset password mail</param>
        /// <returns></returns>
        void RequestPasswordUser (string email, string hostUrl);
  
        /// <summary>
        /// Request to send the reset password mail to user
        /// </summary>
        /// <remarks>
        /// Request to send the reset password mail to user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">user email who wants to get the reset password mail</param>
        /// <param name="hostUrl">front-end host URL to be used in the link on the reset password mail</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RequestPasswordUserWithHttpInfo (string email, string hostUrl);
        
        /// <summary>
        /// Update an address
        /// </summary>
        /// <remarks>
        /// Update an address
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressId">Address ID</param>
        /// <param name="jSONBody">Address json to create a adress</param>
        /// <returns>Address</returns>
        Address UpdateAddress (string addressId, Address jSONBody);
  
        /// <summary>
        /// Update an address
        /// </summary>
        /// <remarks>
        /// Update an address
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressId">Address ID</param>
        /// <param name="jSONBody">Address json to create a adress</param>
        /// <returns>ApiResponse of Address</returns>
        ApiResponse<Address> UpdateAddressWithHttpInfo (string addressId, Address jSONBody);
        
        /// <summary>
        /// Update a credit card
        /// </summary>
        /// <remarks>
        /// Update a credit card
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ccId">CreditCard ID</param>
        /// <param name="jSONBody">CreditCard json to update the information. cc_id in json is not used.</param>
        /// <returns>CreditCard</returns>
        CreditCard UpdateCreditcard (string ccId, CreditCard jSONBody);
  
        /// <summary>
        /// Update a credit card
        /// </summary>
        /// <remarks>
        /// Update a credit card
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ccId">CreditCard ID</param>
        /// <param name="jSONBody">CreditCard json to update the information. cc_id in json is not used.</param>
        /// <returns>ApiResponse of CreditCard</returns>
        ApiResponse<CreditCard> UpdateCreditcardWithHttpInfo (string ccId, CreditCard jSONBody);
        
        /// <summary>
        /// Updates a user
        /// </summary>
        /// <remarks>
        /// Updates a user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="jSONBody">User json to update a user</param>
        /// <returns>User</returns>
        User UpdateUser (string userId, UpdateUserOptions jSONBody);
  
        /// <summary>
        /// Updates a user
        /// </summary>
        /// <remarks>
        /// Updates a user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="jSONBody">User json to update a user</param>
        /// <returns>ApiResponse of User</returns>
        ApiResponse<User> UpdateUserWithHttpInfo (string userId, UpdateUserOptions jSONBody);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Activates a user
        /// </summary>
        /// <remarks>
        /// Activates a user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">json to activate a user</param>
        /// <returns>Task of UserAuthenticated</returns>
        System.Threading.Tasks.Task<UserAuthenticated> ActivateUserAsync (ActivateUserOptions jSONBody);

        /// <summary>
        /// Activates a user
        /// </summary>
        /// <remarks>
        /// Activates a user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">json to activate a user</param>
        /// <returns>Task of ApiResponse (UserAuthenticated)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserAuthenticated>> ActivateUserAsyncWithHttpInfo (ActivateUserOptions jSONBody);
        
        /// <summary>
        /// Authenticates a user
        /// </summary>
        /// <remarks>
        /// Authenticates a user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">json to authenticate a user</param>
        /// <returns>Task of UserAuthenticated</returns>
        System.Threading.Tasks.Task<UserAuthenticated> AuthenticateUserAsync (AuthenticateUserOptions jSONBody);

        /// <summary>
        /// Authenticates a user
        /// </summary>
        /// <remarks>
        /// Authenticates a user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">json to authenticate a user</param>
        /// <returns>Task of ApiResponse (UserAuthenticated)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserAuthenticated>> AuthenticateUserAsyncWithHttpInfo (AuthenticateUserOptions jSONBody);
        
        /// <summary>
        /// Change user&#39;s password
        /// </summary>
        /// <remarks>
        /// Change user&#39;s password
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">json to change user&#39;s password. New password and password_token are needed.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ChangePasswordAsync (PasswordOptions jSONBody);

        /// <summary>
        /// Change user&#39;s password
        /// </summary>
        /// <remarks>
        /// Change user&#39;s password
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">json to change user&#39;s password. New password and password_token are needed.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ChangePasswordAsyncWithHttpInfo (PasswordOptions jSONBody);
        
        /// <summary>
        /// Creates a new address of user
        /// </summary>
        /// <remarks>
        /// Creates a new address of user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Address json to create a address</param>
        /// <returns>Task of Address</returns>
        System.Threading.Tasks.Task<Address> CreateAddressAsync (Address jSONBody);

        /// <summary>
        /// Creates a new address of user
        /// </summary>
        /// <remarks>
        /// Creates a new address of user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Address json to create a address</param>
        /// <returns>Task of ApiResponse (Address)</returns>
        System.Threading.Tasks.Task<ApiResponse<Address>> CreateAddressAsyncWithHttpInfo (Address jSONBody);
        
        /// <summary>
        /// Creates a new credit card of user
        /// </summary>
        /// <remarks>
        /// Creates a new credit card of user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Address json to create a credit card. cc_id is not used.</param>
        /// <returns>Task of Address</returns>
        System.Threading.Tasks.Task<Address> CreateCreditcardAsync (CreditCard jSONBody);

        /// <summary>
        /// Creates a new credit card of user
        /// </summary>
        /// <remarks>
        /// Creates a new credit card of user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Address json to create a credit card. cc_id is not used.</param>
        /// <returns>Task of ApiResponse (Address)</returns>
        System.Threading.Tasks.Task<ApiResponse<Address>> CreateCreditcardAsyncWithHttpInfo (CreditCard jSONBody);
        
        /// <summary>
        /// Creates a new user
        /// </summary>
        /// <remarks>
        /// Creates a new user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">User json to create a new user</param>
        /// <param name="activationRequired">Additional activation is necessary to enable the created user (optional, default to false)</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> CreateUserAsync (CreateUserOptions jSONBody, bool? activationRequired = null);

        /// <summary>
        /// Creates a new user
        /// </summary>
        /// <remarks>
        /// Creates a new user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">User json to create a new user</param>
        /// <param name="activationRequired">Additional activation is necessary to enable the created user (optional, default to false)</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> CreateUserAsyncWithHttpInfo (CreateUserOptions jSONBody, bool? activationRequired = null);
        
        /// <summary>
        /// Get addresses of user
        /// </summary>
        /// <remarks>
        /// Get addresses of user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param>
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param>
        /// <returns>Task of Addresses</returns>
        System.Threading.Tasks.Task<Addresses> GetAddressAsync (int? page = null, int? perPage = null);

        /// <summary>
        /// Get addresses of user
        /// </summary>
        /// <remarks>
        /// Get addresses of user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param>
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param>
        /// <returns>Task of ApiResponse (Addresses)</returns>
        System.Threading.Tasks.Task<ApiResponse<Addresses>> GetAddressAsyncWithHttpInfo (int? page = null, int? perPage = null);
        
        /// <summary>
        /// Get credit cards of user
        /// </summary>
        /// <remarks>
        /// Get credit cards of user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param>
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param>
        /// <returns>Task of CreditCards</returns>
        System.Threading.Tasks.Task<CreditCards> GetCreditcardsAsync (int? page = null, int? perPage = null);

        /// <summary>
        /// Get credit cards of user
        /// </summary>
        /// <remarks>
        /// Get credit cards of user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param>
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param>
        /// <returns>Task of ApiResponse (CreditCards)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreditCards>> GetCreditcardsAsyncWithHttpInfo (int? page = null, int? perPage = null);
        
        /// <summary>
        /// Get the token to change user&#39;s password
        /// </summary>
        /// <remarks>
        /// Get the token to change user&#39;s password
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">json to get the token for changing user&#39;s password. The original password should be offered.</param>
        /// <returns>Task of PasswordToken</returns>
        System.Threading.Tasks.Task<PasswordToken> GetPasswordTokenAsync (PasswordTokenOptions jSONBody);

        /// <summary>
        /// Get the token to change user&#39;s password
        /// </summary>
        /// <remarks>
        /// Get the token to change user&#39;s password
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">json to get the token for changing user&#39;s password. The original password should be offered.</param>
        /// <returns>Task of ApiResponse (PasswordToken)</returns>
        System.Threading.Tasks.Task<ApiResponse<PasswordToken>> GetPasswordTokenAsyncWithHttpInfo (PasswordTokenOptions jSONBody);
        
        /// <summary>
        /// Get a user
        /// </summary>
        /// <remarks>
        /// Get a user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> GetUserAsync (string userId);

        /// <summary>
        /// Get a user
        /// </summary>
        /// <remarks>
        /// Get a user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> GetUserAsyncWithHttpInfo (string userId);
        
        /// <summary>
        /// Get options to create/update user
        /// </summary>
        /// <remarks>
        /// Get options to create/update user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UserOptions</returns>
        System.Threading.Tasks.Task<UserOptions> OptionsUserAsync ();

        /// <summary>
        /// Get options to create/update user
        /// </summary>
        /// <remarks>
        /// Get options to create/update user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UserOptions)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserOptions>> OptionsUserAsyncWithHttpInfo ();
        
        /// <summary>
        /// Request to send the activation mail to user
        /// </summary>
        /// <remarks>
        /// Request to send the activation mail to user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">user email who wants to get the activation mail</param>
        /// <param name="hostUrl">front-end host URL to be used in the link on the activation mail</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RequestActivationUserAsync (string email, string hostUrl);

        /// <summary>
        /// Request to send the activation mail to user
        /// </summary>
        /// <remarks>
        /// Request to send the activation mail to user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">user email who wants to get the activation mail</param>
        /// <param name="hostUrl">front-end host URL to be used in the link on the activation mail</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> RequestActivationUserAsyncWithHttpInfo (string email, string hostUrl);
        
        /// <summary>
        /// Request to send the reset password mail to user
        /// </summary>
        /// <remarks>
        /// Request to send the reset password mail to user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">user email who wants to get the reset password mail</param>
        /// <param name="hostUrl">front-end host URL to be used in the link on the reset password mail</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RequestPasswordUserAsync (string email, string hostUrl);

        /// <summary>
        /// Request to send the reset password mail to user
        /// </summary>
        /// <remarks>
        /// Request to send the reset password mail to user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">user email who wants to get the reset password mail</param>
        /// <param name="hostUrl">front-end host URL to be used in the link on the reset password mail</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> RequestPasswordUserAsyncWithHttpInfo (string email, string hostUrl);
        
        /// <summary>
        /// Update an address
        /// </summary>
        /// <remarks>
        /// Update an address
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressId">Address ID</param>
        /// <param name="jSONBody">Address json to create a adress</param>
        /// <returns>Task of Address</returns>
        System.Threading.Tasks.Task<Address> UpdateAddressAsync (string addressId, Address jSONBody);

        /// <summary>
        /// Update an address
        /// </summary>
        /// <remarks>
        /// Update an address
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressId">Address ID</param>
        /// <param name="jSONBody">Address json to create a adress</param>
        /// <returns>Task of ApiResponse (Address)</returns>
        System.Threading.Tasks.Task<ApiResponse<Address>> UpdateAddressAsyncWithHttpInfo (string addressId, Address jSONBody);
        
        /// <summary>
        /// Update a credit card
        /// </summary>
        /// <remarks>
        /// Update a credit card
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ccId">CreditCard ID</param>
        /// <param name="jSONBody">CreditCard json to update the information. cc_id in json is not used.</param>
        /// <returns>Task of CreditCard</returns>
        System.Threading.Tasks.Task<CreditCard> UpdateCreditcardAsync (string ccId, CreditCard jSONBody);

        /// <summary>
        /// Update a credit card
        /// </summary>
        /// <remarks>
        /// Update a credit card
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ccId">CreditCard ID</param>
        /// <param name="jSONBody">CreditCard json to update the information. cc_id in json is not used.</param>
        /// <returns>Task of ApiResponse (CreditCard)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreditCard>> UpdateCreditcardAsyncWithHttpInfo (string ccId, CreditCard jSONBody);
        
        /// <summary>
        /// Updates a user
        /// </summary>
        /// <remarks>
        /// Updates a user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="jSONBody">User json to update a user</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> UpdateUserAsync (string userId, UpdateUserOptions jSONBody);

        /// <summary>
        /// Updates a user
        /// </summary>
        /// <remarks>
        /// Updates a user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="jSONBody">User json to update a user</param>
        /// <returns>Task of ApiResponse (User)</returns>
        System.Threading.Tasks.Task<ApiResponse<User>> UpdateUserAsyncWithHttpInfo (string userId, UpdateUserOptions jSONBody);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UsersApi : IUsersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UsersApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        
        /// <summary>
        /// Activates a user Activates a user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">json to activate a user</param> 
        /// <returns>UserAuthenticated</returns>
        public UserAuthenticated ActivateUser (ActivateUserOptions jSONBody)
        {
             ApiResponse<UserAuthenticated> localVarResponse = ActivateUserWithHttpInfo(jSONBody);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Activates a user Activates a user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">json to activate a user</param> 
        /// <returns>ApiResponse of UserAuthenticated</returns>
        public ApiResponse< UserAuthenticated > ActivateUserWithHttpInfo (ActivateUserOptions jSONBody)
        {
            
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null)
                throw new ApiException(400, "Missing required parameter 'jSONBody' when calling UsersApi->ActivateUser");
            
    
            var localVarPath = "/users/activate";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (jSONBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(jSONBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = jSONBody; // byte array
            }

            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ActivateUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ActivateUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UserAuthenticated>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserAuthenticated) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAuthenticated)));
            
        }

        
        /// <summary>
        /// Activates a user Activates a user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">json to activate a user</param>
        /// <returns>Task of UserAuthenticated</returns>
        public async System.Threading.Tasks.Task<UserAuthenticated> ActivateUserAsync (ActivateUserOptions jSONBody)
        {
             ApiResponse<UserAuthenticated> localVarResponse = await ActivateUserAsyncWithHttpInfo(jSONBody);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Activates a user Activates a user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">json to activate a user</param>
        /// <returns>Task of ApiResponse (UserAuthenticated)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserAuthenticated>> ActivateUserAsyncWithHttpInfo (ActivateUserOptions jSONBody)
        {
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null) throw new ApiException(400, "Missing required parameter 'jSONBody' when calling ActivateUser");
            
    
            var localVarPath = "/users/activate";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (jSONBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(jSONBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = jSONBody; // byte array
            }

            
            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ActivateUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ActivateUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserAuthenticated>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserAuthenticated) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAuthenticated)));
            
        }
        
        /// <summary>
        /// Authenticates a user Authenticates a user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">json to authenticate a user</param> 
        /// <returns>UserAuthenticated</returns>
        public UserAuthenticated AuthenticateUser (AuthenticateUserOptions jSONBody)
        {
             ApiResponse<UserAuthenticated> localVarResponse = AuthenticateUserWithHttpInfo(jSONBody);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Authenticates a user Authenticates a user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">json to authenticate a user</param> 
        /// <returns>ApiResponse of UserAuthenticated</returns>
        public ApiResponse< UserAuthenticated > AuthenticateUserWithHttpInfo (AuthenticateUserOptions jSONBody)
        {
            
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null)
                throw new ApiException(400, "Missing required parameter 'jSONBody' when calling UsersApi->AuthenticateUser");
            
    
            var localVarPath = "/users/authenticate";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (jSONBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(jSONBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = jSONBody; // byte array
            }

            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AuthenticateUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthenticateUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UserAuthenticated>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserAuthenticated) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAuthenticated)));
            
        }

        
        /// <summary>
        /// Authenticates a user Authenticates a user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">json to authenticate a user</param>
        /// <returns>Task of UserAuthenticated</returns>
        public async System.Threading.Tasks.Task<UserAuthenticated> AuthenticateUserAsync (AuthenticateUserOptions jSONBody)
        {
             ApiResponse<UserAuthenticated> localVarResponse = await AuthenticateUserAsyncWithHttpInfo(jSONBody);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Authenticates a user Authenticates a user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">json to authenticate a user</param>
        /// <returns>Task of ApiResponse (UserAuthenticated)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserAuthenticated>> AuthenticateUserAsyncWithHttpInfo (AuthenticateUserOptions jSONBody)
        {
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null) throw new ApiException(400, "Missing required parameter 'jSONBody' when calling AuthenticateUser");
            
    
            var localVarPath = "/users/authenticate";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (jSONBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(jSONBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = jSONBody; // byte array
            }

            
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AuthenticateUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AuthenticateUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserAuthenticated>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserAuthenticated) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserAuthenticated)));
            
        }
        
        /// <summary>
        /// Change user&#39;s password Change user&#39;s password
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">json to change user&#39;s password. New password and password_token are needed.</param> 
        /// <returns></returns>
        public void ChangePassword (PasswordOptions jSONBody)
        {
             ChangePasswordWithHttpInfo(jSONBody);
        }

        /// <summary>
        /// Change user&#39;s password Change user&#39;s password
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">json to change user&#39;s password. New password and password_token are needed.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ChangePasswordWithHttpInfo (PasswordOptions jSONBody)
        {
            
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null)
                throw new ApiException(400, "Missing required parameter 'jSONBody' when calling UsersApi->ChangePassword");
            
    
            var localVarPath = "/users/password";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (jSONBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(jSONBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = jSONBody; // byte array
            }

            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ChangePassword: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ChangePassword: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Change user&#39;s password Change user&#39;s password
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">json to change user&#39;s password. New password and password_token are needed.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ChangePasswordAsync (PasswordOptions jSONBody)
        {
             await ChangePasswordAsyncWithHttpInfo(jSONBody);

        }

        /// <summary>
        /// Change user&#39;s password Change user&#39;s password
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">json to change user&#39;s password. New password and password_token are needed.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ChangePasswordAsyncWithHttpInfo (PasswordOptions jSONBody)
        {
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null) throw new ApiException(400, "Missing required parameter 'jSONBody' when calling ChangePassword");
            
    
            var localVarPath = "/users/password";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (jSONBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(jSONBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = jSONBody; // byte array
            }

            
            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ChangePassword: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ChangePassword: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Creates a new address of user Creates a new address of user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Address json to create a address</param> 
        /// <returns>Address</returns>
        public Address CreateAddress (Address jSONBody)
        {
             ApiResponse<Address> localVarResponse = CreateAddressWithHttpInfo(jSONBody);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creates a new address of user Creates a new address of user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Address json to create a address</param> 
        /// <returns>ApiResponse of Address</returns>
        public ApiResponse< Address > CreateAddressWithHttpInfo (Address jSONBody)
        {
            
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null)
                throw new ApiException(400, "Missing required parameter 'jSONBody' when calling UsersApi->CreateAddress");
            
    
            var localVarPath = "/users/addresses";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (jSONBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(jSONBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = jSONBody; // byte array
            }

            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CreateAddress: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateAddress: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Address>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Address) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Address)));
            
        }

        
        /// <summary>
        /// Creates a new address of user Creates a new address of user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Address json to create a address</param>
        /// <returns>Task of Address</returns>
        public async System.Threading.Tasks.Task<Address> CreateAddressAsync (Address jSONBody)
        {
             ApiResponse<Address> localVarResponse = await CreateAddressAsyncWithHttpInfo(jSONBody);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creates a new address of user Creates a new address of user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Address json to create a address</param>
        /// <returns>Task of ApiResponse (Address)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Address>> CreateAddressAsyncWithHttpInfo (Address jSONBody)
        {
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null) throw new ApiException(400, "Missing required parameter 'jSONBody' when calling CreateAddress");
            
    
            var localVarPath = "/users/addresses";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (jSONBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(jSONBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = jSONBody; // byte array
            }

            
            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CreateAddress: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateAddress: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Address>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Address) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Address)));
            
        }
        
        /// <summary>
        /// Creates a new credit card of user Creates a new credit card of user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Address json to create a credit card. cc_id is not used.</param> 
        /// <returns>Address</returns>
        public Address CreateCreditcard (CreditCard jSONBody)
        {
             ApiResponse<Address> localVarResponse = CreateCreditcardWithHttpInfo(jSONBody);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creates a new credit card of user Creates a new credit card of user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Address json to create a credit card. cc_id is not used.</param> 
        /// <returns>ApiResponse of Address</returns>
        public ApiResponse< Address > CreateCreditcardWithHttpInfo (CreditCard jSONBody)
        {
            
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null)
                throw new ApiException(400, "Missing required parameter 'jSONBody' when calling UsersApi->CreateCreditcard");
            
    
            var localVarPath = "/users/creditcards";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (jSONBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(jSONBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = jSONBody; // byte array
            }

            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CreateCreditcard: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateCreditcard: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Address>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Address) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Address)));
            
        }

        
        /// <summary>
        /// Creates a new credit card of user Creates a new credit card of user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Address json to create a credit card. cc_id is not used.</param>
        /// <returns>Task of Address</returns>
        public async System.Threading.Tasks.Task<Address> CreateCreditcardAsync (CreditCard jSONBody)
        {
             ApiResponse<Address> localVarResponse = await CreateCreditcardAsyncWithHttpInfo(jSONBody);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creates a new credit card of user Creates a new credit card of user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Address json to create a credit card. cc_id is not used.</param>
        /// <returns>Task of ApiResponse (Address)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Address>> CreateCreditcardAsyncWithHttpInfo (CreditCard jSONBody)
        {
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null) throw new ApiException(400, "Missing required parameter 'jSONBody' when calling CreateCreditcard");
            
    
            var localVarPath = "/users/creditcards";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (jSONBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(jSONBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = jSONBody; // byte array
            }

            
            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CreateCreditcard: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateCreditcard: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Address>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Address) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Address)));
            
        }
        
        /// <summary>
        /// Creates a new user Creates a new user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">User json to create a new user</param> 
        /// <param name="activationRequired">Additional activation is necessary to enable the created user (optional, default to false)</param> 
        /// <returns>User</returns>
        public User CreateUser (CreateUserOptions jSONBody, bool? activationRequired = null)
        {
             ApiResponse<User> localVarResponse = CreateUserWithHttpInfo(jSONBody, activationRequired);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creates a new user Creates a new user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">User json to create a new user</param> 
        /// <param name="activationRequired">Additional activation is necessary to enable the created user (optional, default to false)</param> 
        /// <returns>ApiResponse of User</returns>
        public ApiResponse< User > CreateUserWithHttpInfo (CreateUserOptions jSONBody, bool? activationRequired = null)
        {
            
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null)
                throw new ApiException(400, "Missing required parameter 'jSONBody' when calling UsersApi->CreateUser");
            
    
            var localVarPath = "/users";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (activationRequired != null) localVarQueryParams.Add("activation_required", Configuration.ApiClient.ParameterToString(activationRequired)); // query parameter
            
            
            
            if (jSONBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(jSONBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = jSONBody; // byte array
            }

            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CreateUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
            
        }

        
        /// <summary>
        /// Creates a new user Creates a new user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">User json to create a new user</param>
        /// <param name="activationRequired">Additional activation is necessary to enable the created user (optional, default to false)</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> CreateUserAsync (CreateUserOptions jSONBody, bool? activationRequired = null)
        {
             ApiResponse<User> localVarResponse = await CreateUserAsyncWithHttpInfo(jSONBody, activationRequired);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creates a new user Creates a new user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">User json to create a new user</param>
        /// <param name="activationRequired">Additional activation is necessary to enable the created user (optional, default to false)</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> CreateUserAsyncWithHttpInfo (CreateUserOptions jSONBody, bool? activationRequired = null)
        {
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null) throw new ApiException(400, "Missing required parameter 'jSONBody' when calling CreateUser");
            
    
            var localVarPath = "/users";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (activationRequired != null) localVarQueryParams.Add("activation_required", Configuration.ApiClient.ParameterToString(activationRequired)); // query parameter
            
            
            
            if (jSONBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(jSONBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = jSONBody; // byte array
            }

            
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CreateUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
            
        }
        
        /// <summary>
        /// Get addresses of user Get addresses of user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param> 
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param> 
        /// <returns>Addresses</returns>
        public Addresses GetAddress (int? page = null, int? perPage = null)
        {
             ApiResponse<Addresses> localVarResponse = GetAddressWithHttpInfo(page, perPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get addresses of user Get addresses of user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param> 
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param> 
        /// <returns>ApiResponse of Addresses</returns>
        public ApiResponse< Addresses > GetAddressWithHttpInfo (int? page = null, int? perPage = null)
        {
            
    
            var localVarPath = "/users/addresses";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("per_page", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            
            
            
            

            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAddress: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAddress: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Addresses>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Addresses) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Addresses)));
            
        }

        
        /// <summary>
        /// Get addresses of user Get addresses of user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param>
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param>
        /// <returns>Task of Addresses</returns>
        public async System.Threading.Tasks.Task<Addresses> GetAddressAsync (int? page = null, int? perPage = null)
        {
             ApiResponse<Addresses> localVarResponse = await GetAddressAsyncWithHttpInfo(page, perPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get addresses of user Get addresses of user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param>
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param>
        /// <returns>Task of ApiResponse (Addresses)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Addresses>> GetAddressAsyncWithHttpInfo (int? page = null, int? perPage = null)
        {
            
    
            var localVarPath = "/users/addresses";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("per_page", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            
            
            
            

            
            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAddress: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAddress: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Addresses>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Addresses) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Addresses)));
            
        }
        
        /// <summary>
        /// Get credit cards of user Get credit cards of user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param> 
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param> 
        /// <returns>CreditCards</returns>
        public CreditCards GetCreditcards (int? page = null, int? perPage = null)
        {
             ApiResponse<CreditCards> localVarResponse = GetCreditcardsWithHttpInfo(page, perPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get credit cards of user Get credit cards of user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param> 
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param> 
        /// <returns>ApiResponse of CreditCards</returns>
        public ApiResponse< CreditCards > GetCreditcardsWithHttpInfo (int? page = null, int? perPage = null)
        {
            
    
            var localVarPath = "/users/creditcards";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("per_page", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            
            
            
            

            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCreditcards: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCreditcards: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CreditCards>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreditCards) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreditCards)));
            
        }

        
        /// <summary>
        /// Get credit cards of user Get credit cards of user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param>
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param>
        /// <returns>Task of CreditCards</returns>
        public async System.Threading.Tasks.Task<CreditCards> GetCreditcardsAsync (int? page = null, int? perPage = null)
        {
             ApiResponse<CreditCards> localVarResponse = await GetCreditcardsAsyncWithHttpInfo(page, perPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get credit cards of user Get credit cards of user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param>
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param>
        /// <returns>Task of ApiResponse (CreditCards)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreditCards>> GetCreditcardsAsyncWithHttpInfo (int? page = null, int? perPage = null)
        {
            
    
            var localVarPath = "/users/creditcards";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("per_page", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            
            
            
            

            
            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetCreditcards: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCreditcards: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CreditCards>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreditCards) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreditCards)));
            
        }
        
        /// <summary>
        /// Get the token to change user&#39;s password Get the token to change user&#39;s password
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">json to get the token for changing user&#39;s password. The original password should be offered.</param> 
        /// <returns>PasswordToken</returns>
        public PasswordToken GetPasswordToken (PasswordTokenOptions jSONBody)
        {
             ApiResponse<PasswordToken> localVarResponse = GetPasswordTokenWithHttpInfo(jSONBody);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the token to change user&#39;s password Get the token to change user&#39;s password
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">json to get the token for changing user&#39;s password. The original password should be offered.</param> 
        /// <returns>ApiResponse of PasswordToken</returns>
        public ApiResponse< PasswordToken > GetPasswordTokenWithHttpInfo (PasswordTokenOptions jSONBody)
        {
            
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null)
                throw new ApiException(400, "Missing required parameter 'jSONBody' when calling UsersApi->GetPasswordToken");
            
    
            var localVarPath = "/users/password_token";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (jSONBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(jSONBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = jSONBody; // byte array
            }

            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetPasswordToken: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPasswordToken: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PasswordToken>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PasswordToken) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PasswordToken)));
            
        }

        
        /// <summary>
        /// Get the token to change user&#39;s password Get the token to change user&#39;s password
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">json to get the token for changing user&#39;s password. The original password should be offered.</param>
        /// <returns>Task of PasswordToken</returns>
        public async System.Threading.Tasks.Task<PasswordToken> GetPasswordTokenAsync (PasswordTokenOptions jSONBody)
        {
             ApiResponse<PasswordToken> localVarResponse = await GetPasswordTokenAsyncWithHttpInfo(jSONBody);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the token to change user&#39;s password Get the token to change user&#39;s password
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">json to get the token for changing user&#39;s password. The original password should be offered.</param>
        /// <returns>Task of ApiResponse (PasswordToken)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PasswordToken>> GetPasswordTokenAsyncWithHttpInfo (PasswordTokenOptions jSONBody)
        {
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null) throw new ApiException(400, "Missing required parameter 'jSONBody' when calling GetPasswordToken");
            
    
            var localVarPath = "/users/password_token";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (jSONBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(jSONBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = jSONBody; // byte array
            }

            
            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetPasswordToken: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPasswordToken: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PasswordToken>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PasswordToken) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PasswordToken)));
            
        }
        
        /// <summary>
        /// Get a user Get a user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param> 
        /// <returns>User</returns>
        public User GetUser (string userId)
        {
             ApiResponse<User> localVarResponse = GetUserWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a user Get a user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param> 
        /// <returns>ApiResponse of User</returns>
        public ApiResponse< User > GetUserWithHttpInfo (string userId)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->GetUser");
            
    
            var localVarPath = "/users/{user_id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (userId != null) localVarPathParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            

            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
            
        }

        
        /// <summary>
        /// Get a user Get a user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> GetUserAsync (string userId)
        {
             ApiResponse<User> localVarResponse = await GetUserAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a user Get a user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> GetUserAsyncWithHttpInfo (string userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUser");
            
    
            var localVarPath = "/users/{user_id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (userId != null) localVarPathParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            

            
            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
            
        }
        
        /// <summary>
        /// Get options to create/update user Get options to create/update user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UserOptions</returns>
        public UserOptions OptionsUser ()
        {
             ApiResponse<UserOptions> localVarResponse = OptionsUserWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get options to create/update user Get options to create/update user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UserOptions</returns>
        public ApiResponse< UserOptions > OptionsUserWithHttpInfo ()
        {
            
    
            var localVarPath = "/users/options";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            

            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling OptionsUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OptionsUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UserOptions>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserOptions) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserOptions)));
            
        }

        
        /// <summary>
        /// Get options to create/update user Get options to create/update user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UserOptions</returns>
        public async System.Threading.Tasks.Task<UserOptions> OptionsUserAsync ()
        {
             ApiResponse<UserOptions> localVarResponse = await OptionsUserAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get options to create/update user Get options to create/update user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UserOptions)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserOptions>> OptionsUserAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/users/options";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            

            
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling OptionsUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OptionsUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserOptions>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserOptions) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserOptions)));
            
        }
        
        /// <summary>
        /// Request to send the activation mail to user Request to send the activation mail to user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">user email who wants to get the activation mail</param> 
        /// <param name="hostUrl">front-end host URL to be used in the link on the activation mail</param> 
        /// <returns></returns>
        public void RequestActivationUser (string email, string hostUrl)
        {
             RequestActivationUserWithHttpInfo(email, hostUrl);
        }

        /// <summary>
        /// Request to send the activation mail to user Request to send the activation mail to user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">user email who wants to get the activation mail</param> 
        /// <param name="hostUrl">front-end host URL to be used in the link on the activation mail</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> RequestActivationUserWithHttpInfo (string email, string hostUrl)
        {
            
            // verify the required parameter 'email' is set
            if (email == null)
                throw new ApiException(400, "Missing required parameter 'email' when calling UsersApi->RequestActivationUser");
            
            // verify the required parameter 'hostUrl' is set
            if (hostUrl == null)
                throw new ApiException(400, "Missing required parameter 'hostUrl' when calling UsersApi->RequestActivationUser");
            
    
            var localVarPath = "/users/activate";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            if (email != null) localVarFormParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // form parameter
            if (hostUrl != null) localVarFormParams.Add("host_url", Configuration.ApiClient.ParameterToString(hostUrl)); // form parameter
            
            

            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RequestActivationUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RequestActivationUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Request to send the activation mail to user Request to send the activation mail to user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">user email who wants to get the activation mail</param>
        /// <param name="hostUrl">front-end host URL to be used in the link on the activation mail</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RequestActivationUserAsync (string email, string hostUrl)
        {
             await RequestActivationUserAsyncWithHttpInfo(email, hostUrl);

        }

        /// <summary>
        /// Request to send the activation mail to user Request to send the activation mail to user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">user email who wants to get the activation mail</param>
        /// <param name="hostUrl">front-end host URL to be used in the link on the activation mail</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> RequestActivationUserAsyncWithHttpInfo (string email, string hostUrl)
        {
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling RequestActivationUser");
            // verify the required parameter 'hostUrl' is set
            if (hostUrl == null) throw new ApiException(400, "Missing required parameter 'hostUrl' when calling RequestActivationUser");
            
    
            var localVarPath = "/users/activate";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            if (email != null) localVarFormParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // form parameter
            if (hostUrl != null) localVarFormParams.Add("host_url", Configuration.ApiClient.ParameterToString(hostUrl)); // form parameter
            
            

            
            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RequestActivationUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RequestActivationUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Request to send the reset password mail to user Request to send the reset password mail to user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">user email who wants to get the reset password mail</param> 
        /// <param name="hostUrl">front-end host URL to be used in the link on the reset password mail</param> 
        /// <returns></returns>
        public void RequestPasswordUser (string email, string hostUrl)
        {
             RequestPasswordUserWithHttpInfo(email, hostUrl);
        }

        /// <summary>
        /// Request to send the reset password mail to user Request to send the reset password mail to user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">user email who wants to get the reset password mail</param> 
        /// <param name="hostUrl">front-end host URL to be used in the link on the reset password mail</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> RequestPasswordUserWithHttpInfo (string email, string hostUrl)
        {
            
            // verify the required parameter 'email' is set
            if (email == null)
                throw new ApiException(400, "Missing required parameter 'email' when calling UsersApi->RequestPasswordUser");
            
            // verify the required parameter 'hostUrl' is set
            if (hostUrl == null)
                throw new ApiException(400, "Missing required parameter 'hostUrl' when calling UsersApi->RequestPasswordUser");
            
    
            var localVarPath = "/users/password";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            if (email != null) localVarFormParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // form parameter
            if (hostUrl != null) localVarFormParams.Add("host_url", Configuration.ApiClient.ParameterToString(hostUrl)); // form parameter
            
            

            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RequestPasswordUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RequestPasswordUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Request to send the reset password mail to user Request to send the reset password mail to user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">user email who wants to get the reset password mail</param>
        /// <param name="hostUrl">front-end host URL to be used in the link on the reset password mail</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RequestPasswordUserAsync (string email, string hostUrl)
        {
             await RequestPasswordUserAsyncWithHttpInfo(email, hostUrl);

        }

        /// <summary>
        /// Request to send the reset password mail to user Request to send the reset password mail to user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="email">user email who wants to get the reset password mail</param>
        /// <param name="hostUrl">front-end host URL to be used in the link on the reset password mail</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> RequestPasswordUserAsyncWithHttpInfo (string email, string hostUrl)
        {
            // verify the required parameter 'email' is set
            if (email == null) throw new ApiException(400, "Missing required parameter 'email' when calling RequestPasswordUser");
            // verify the required parameter 'hostUrl' is set
            if (hostUrl == null) throw new ApiException(400, "Missing required parameter 'hostUrl' when calling RequestPasswordUser");
            
    
            var localVarPath = "/users/password";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            if (email != null) localVarFormParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // form parameter
            if (hostUrl != null) localVarFormParams.Add("host_url", Configuration.ApiClient.ParameterToString(hostUrl)); // form parameter
            
            

            
            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RequestPasswordUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RequestPasswordUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update an address Update an address
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressId">Address ID</param> 
        /// <param name="jSONBody">Address json to create a adress</param> 
        /// <returns>Address</returns>
        public Address UpdateAddress (string addressId, Address jSONBody)
        {
             ApiResponse<Address> localVarResponse = UpdateAddressWithHttpInfo(addressId, jSONBody);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an address Update an address
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressId">Address ID</param> 
        /// <param name="jSONBody">Address json to create a adress</param> 
        /// <returns>ApiResponse of Address</returns>
        public ApiResponse< Address > UpdateAddressWithHttpInfo (string addressId, Address jSONBody)
        {
            
            // verify the required parameter 'addressId' is set
            if (addressId == null)
                throw new ApiException(400, "Missing required parameter 'addressId' when calling UsersApi->UpdateAddress");
            
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null)
                throw new ApiException(400, "Missing required parameter 'jSONBody' when calling UsersApi->UpdateAddress");
            
    
            var localVarPath = "/users/addresses/{address_id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (addressId != null) localVarPathParams.Add("address_id", Configuration.ApiClient.ParameterToString(addressId)); // path parameter
            
            
            
            
            if (jSONBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(jSONBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = jSONBody; // byte array
            }

            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdateAddress: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateAddress: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Address>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Address) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Address)));
            
        }

        
        /// <summary>
        /// Update an address Update an address
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressId">Address ID</param>
        /// <param name="jSONBody">Address json to create a adress</param>
        /// <returns>Task of Address</returns>
        public async System.Threading.Tasks.Task<Address> UpdateAddressAsync (string addressId, Address jSONBody)
        {
             ApiResponse<Address> localVarResponse = await UpdateAddressAsyncWithHttpInfo(addressId, jSONBody);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an address Update an address
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressId">Address ID</param>
        /// <param name="jSONBody">Address json to create a adress</param>
        /// <returns>Task of ApiResponse (Address)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Address>> UpdateAddressAsyncWithHttpInfo (string addressId, Address jSONBody)
        {
            // verify the required parameter 'addressId' is set
            if (addressId == null) throw new ApiException(400, "Missing required parameter 'addressId' when calling UpdateAddress");
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null) throw new ApiException(400, "Missing required parameter 'jSONBody' when calling UpdateAddress");
            
    
            var localVarPath = "/users/addresses/{address_id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (addressId != null) localVarPathParams.Add("address_id", Configuration.ApiClient.ParameterToString(addressId)); // path parameter
            
            
            
            
            if (jSONBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(jSONBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = jSONBody; // byte array
            }

            
            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdateAddress: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateAddress: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Address>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Address) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Address)));
            
        }
        
        /// <summary>
        /// Update a credit card Update a credit card
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ccId">CreditCard ID</param> 
        /// <param name="jSONBody">CreditCard json to update the information. cc_id in json is not used.</param> 
        /// <returns>CreditCard</returns>
        public CreditCard UpdateCreditcard (string ccId, CreditCard jSONBody)
        {
             ApiResponse<CreditCard> localVarResponse = UpdateCreditcardWithHttpInfo(ccId, jSONBody);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a credit card Update a credit card
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ccId">CreditCard ID</param> 
        /// <param name="jSONBody">CreditCard json to update the information. cc_id in json is not used.</param> 
        /// <returns>ApiResponse of CreditCard</returns>
        public ApiResponse< CreditCard > UpdateCreditcardWithHttpInfo (string ccId, CreditCard jSONBody)
        {
            
            // verify the required parameter 'ccId' is set
            if (ccId == null)
                throw new ApiException(400, "Missing required parameter 'ccId' when calling UsersApi->UpdateCreditcard");
            
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null)
                throw new ApiException(400, "Missing required parameter 'jSONBody' when calling UsersApi->UpdateCreditcard");
            
    
            var localVarPath = "/users/creditcards/{cc_id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (ccId != null) localVarPathParams.Add("cc_id", Configuration.ApiClient.ParameterToString(ccId)); // path parameter
            
            
            
            
            if (jSONBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(jSONBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = jSONBody; // byte array
            }

            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdateCreditcard: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateCreditcard: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CreditCard>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreditCard) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreditCard)));
            
        }

        
        /// <summary>
        /// Update a credit card Update a credit card
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ccId">CreditCard ID</param>
        /// <param name="jSONBody">CreditCard json to update the information. cc_id in json is not used.</param>
        /// <returns>Task of CreditCard</returns>
        public async System.Threading.Tasks.Task<CreditCard> UpdateCreditcardAsync (string ccId, CreditCard jSONBody)
        {
             ApiResponse<CreditCard> localVarResponse = await UpdateCreditcardAsyncWithHttpInfo(ccId, jSONBody);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a credit card Update a credit card
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ccId">CreditCard ID</param>
        /// <param name="jSONBody">CreditCard json to update the information. cc_id in json is not used.</param>
        /// <returns>Task of ApiResponse (CreditCard)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreditCard>> UpdateCreditcardAsyncWithHttpInfo (string ccId, CreditCard jSONBody)
        {
            // verify the required parameter 'ccId' is set
            if (ccId == null) throw new ApiException(400, "Missing required parameter 'ccId' when calling UpdateCreditcard");
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null) throw new ApiException(400, "Missing required parameter 'jSONBody' when calling UpdateCreditcard");
            
    
            var localVarPath = "/users/creditcards/{cc_id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (ccId != null) localVarPathParams.Add("cc_id", Configuration.ApiClient.ParameterToString(ccId)); // path parameter
            
            
            
            
            if (jSONBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(jSONBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = jSONBody; // byte array
            }

            
            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdateCreditcard: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateCreditcard: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CreditCard>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreditCard) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreditCard)));
            
        }
        
        /// <summary>
        /// Updates a user Updates a user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param> 
        /// <param name="jSONBody">User json to update a user</param> 
        /// <returns>User</returns>
        public User UpdateUser (string userId, UpdateUserOptions jSONBody)
        {
             ApiResponse<User> localVarResponse = UpdateUserWithHttpInfo(userId, jSONBody);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Updates a user Updates a user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param> 
        /// <param name="jSONBody">User json to update a user</param> 
        /// <returns>ApiResponse of User</returns>
        public ApiResponse< User > UpdateUserWithHttpInfo (string userId, UpdateUserOptions jSONBody)
        {
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsersApi->UpdateUser");
            
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null)
                throw new ApiException(400, "Missing required parameter 'jSONBody' when calling UsersApi->UpdateUser");
            
    
            var localVarPath = "/users/{user_id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (userId != null) localVarPathParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            if (jSONBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(jSONBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = jSONBody; // byte array
            }

            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdateUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
            
        }

        
        /// <summary>
        /// Updates a user Updates a user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="jSONBody">User json to update a user</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> UpdateUserAsync (string userId, UpdateUserOptions jSONBody)
        {
             ApiResponse<User> localVarResponse = await UpdateUserAsyncWithHttpInfo(userId, jSONBody);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Updates a user Updates a user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">User ID</param>
        /// <param name="jSONBody">User json to update a user</param>
        /// <returns>Task of ApiResponse (User)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<User>> UpdateUserAsyncWithHttpInfo (string userId, UpdateUserOptions jSONBody)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UpdateUser");
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null) throw new ApiException(400, "Missing required parameter 'jSONBody' when calling UpdateUser");
            
    
            var localVarPath = "/users/{user_id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (userId != null) localVarPathParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            
            
            
            
            if (jSONBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(jSONBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = jSONBody; // byte array
            }

            
            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdateUser: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<User>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (User) Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
            
        }
        
    }
    
}
