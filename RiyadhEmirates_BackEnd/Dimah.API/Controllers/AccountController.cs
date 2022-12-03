using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Dimah.Core.Application.Services.Shared;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Dimah.Core.Application.Response;
using Dimah.Core.Application.Services.Accounts;
using Dimah.Core.Application.Dtos;
using Dimah.Core.Application.Interfaces.Helpers;
using Dimah.Core.Application.Dtos.Accounts;

namespace Dimah.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AccountController : BaseController
    {
        private readonly IAccountService _accountService;
        private readonly IConfiguration _config;

        public AccountController(IAccountService accountService, IConfiguration config,
            ILocalizationService localizationService) : base(localizationService)
        {
            _accountService = accountService;
            _config = config;
        }

        [HttpGet("GetUserData/{id?}")]
        [Authorize]
        public IApiResponse GetUserData(int id=0)
        {
            if (id == 0)
                id = UserId;
            return _accountService.GetUserData(id);
        }
        [HttpGet("GetCurrentUserRoles")]
        [Authorize]
        public IApiResponse GetCurrentUserRoles()
        {
            return _accountService.GetCurrentUserRoles(UserId);
        }

        [HttpGet("GetAuthUser")]
        [Authorize]
        public IApiResponse GetAuthUser()
        {
            return _accountService.GetAuthUser(UserId);
        }

        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(int id)
        {
            return _accountService.GetById(id);
        }

        [HttpGet("GetByUserName/{userName}")]
        public IApiResponse GetByUserName(string userName)
        {
            return _accountService.GetByUserName(userName);
        }
        [HttpGet("GetByPhone/{phoneNumber}")]
        public IApiResponse GetByPhone(string phoneNumber)
        {
            return _accountService.GetByPhone(phoneNumber);
        }

        [HttpGet("UserExist/{userName}")]
        public IApiResponse UserExist(string userName)
        {
            return _accountService.UserExist(userName);
        }

        [HttpPost]
        [Route("Login")]
        public IApiResponse Login(UserLoginDto userLoginDto)
        {
            var userResponse = _accountService.Login(userLoginDto);
            if (userResponse.IsSuccess)
            {
                var user = (GetUserDto)userResponse.Data;
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_config.GetSection("AppSettings:TokenSigningKey").Value);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                    new Claim("UserId",user.Id.ToString()),
                    //new Claim("Name", user.NameAr.ToString()),
                    //new Claim("Phone",user.PhoneNumber.ToString())
                   }),

                    Expires = DateTime.UtcNow.AddDays(360),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                userResponse.Data = tokenHandler.WriteToken(token);
            }
            return userResponse;
        }

        [HttpPost]
        [Route("ForgetPassword")]
        public IApiResponse ForgetPassword(ForgetPasswordDto forgetPasswordDto)
        {
            return _accountService.ForgetPassword(forgetPasswordDto);
        }

        [HttpPost]
        [Route("ResetPassword")]
        public IApiResponse ResetPassword(ResetPasswordDto resetPasswordDto)
        {
            return _accountService.ResetPassword(resetPasswordDto);
        }

        [HttpPost]
        [Route("UpdatePassword")]
        public IApiResponse UpdatePassword(UpdatePasswordDto updatePasswordDto)
        {
            updatePasswordDto.UserId = UserId;
            return _accountService.UpdatePassword(updatePasswordDto);
        }

        [HttpPost("ValidateOTP")]
        public IApiResponse ValidateOTP(ValidateOTPDto validateOTPDto)
        {
            return _accountService.ValidateOTP(validateOTPDto);
        }


        [HttpPost("Register")]
        public IApiResponse Register(CreateUserDto createUserDto)
        {
            if (!ModelState.IsValid)
                return new ApiResponse
                {
                    IsSuccess=false,
                    Message = CustumMessages.MsgWarning("رجاء التأكد من صحة البيانات المدخلة")
                };
            return _accountService.Register(createUserDto);
        }

        //[Authorize]
        [HttpPost("UpdateUserProfile")]
        public IApiResponse UpdateUserProfile(UpdateUserProfileDto updateUserProfileDto)
        {
            return _accountService.UpdateUserProfile(updateUserProfileDto);
        }

        [HttpGet("GetUserProfileData/{id}")]
        public IApiResponse GetUserProfileData(int id)
        {
            return _accountService.GetUserProfileData(id);
        }
        
        [HttpGet("CreateEmployee/{userId}")]
        public IApiResponse CreateEmployee(int userId)
        {
            return _accountService.CreateEmployee(userId);
        }
        
        [HttpGet("DeleteEmployee/{userId}")]
        public IApiResponse DeleteEmployee(int userId)
        {
            return _accountService.DeleteEmployee(userId);
        }

    }
}
