using AutoMapper;
using minimumApi.Controllers.Abstraction;
using minimumApi.Models;
using minimumApi.Models.ViewModels.Login;
using minimumApi.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace minimumApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : BaseController
    {
        private readonly ISignInService _signInService;
        public AuthController(ISignInService signInService, IMapper mapper, ILoggerFactory loggerFactory) : base(mapper, loggerFactory)
        {
            this._signInService = signInService;
        }

        /// <summary>
        /// Authentication Service -> Login Method
        /// </summary>
        /// <param name="authObject">Authentication Object</param>
        /// <returns></returns>
        [HttpPost("SignIn")]
        public ServiceResponse<SignInResponseViewModel> SignIn([FromBody] SignInRequestViewModel authObject)
        {
            var response = this._signInService.ActionSignIn(authObject);
            return response;
        }

        /// <summary>
        /// Authentication Service -> Register Method
        /// </summary>
        /// <param name="userObject">User Object</param>
        /// <returns></returns>
        [HttpPost("SignUp")]
        public ServiceResponse<bool> SignUp([FromBody] SignUpViewModel userObject)
        {
            var response = this._signInService.ActionSignUp(userObject);
            return response;
        }

        [HttpPost("AssignUserGroup")]
        public ServiceResponse<bool> AssignUserGroup([FromBody] AssignUserGroupRequestViewModel userObject)
        {
            var response = this._signInService.ActionAssignUserGroup(userObject);
            return response;
        }

        /// <summary>
        /// Authentication Service -> Password Recovery Method
        /// </summary>
        /// <param name="authObject">Authentication Object</param>
        /// <returns></returns>
        [HttpPost("ForgottenPassword")]
        public ServiceResponse<bool> ForgottenPassword([FromBody] ForgottenPasswordViewModel authObject)
        {
            var response = this._signInService.ActionForgottenPassword(authObject);
            return response;
        }
    }
}
