using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Emirates.API.Dtos.Request.User;
using Emirates.API.Dtos.Security.Request;
using Emirates.Core.Application.Models.Request.User;
using Emirates.Core.Application.Services.Security;
using Emirates.Core.Application.Services.Shared;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Emirates.API.Extensions.Dtos.Request.Authentication;
using Emirates.Core.Application.Models.Request.Authenticattion;
using Emirates.Core.Application.Response;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AuthController : BaseController
    {
        private readonly IConfiguration _config;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public AuthController(IUserService userService, IConfiguration config,
            ILocalizationService localizationService, IMapper mapper)
            : base(localizationService)
        {
            _userService = userService;
            _mapper = mapper;
            _config = config;
        }


        [HttpPost]
        [Route(("Register"))]
        public IActionResult Register([FromForm]CreateUserDto createUserDto)
        {
            if (_userService.UserExist(createUserDto.NationalId))
                return BadRequest(GetResponse(false, "اسم المستخدم موجود"));

            _userService.CreatePasswordHash(createUserDto.Password, out byte[] passwordHash, out byte[] passwordSalt);

            CreateUserModel userCreationDto = _mapper.Map<CreateUserModel>(createUserDto);

            userCreationDto.PasswordHash = passwordHash;
            userCreationDto.PasswordSalt = passwordSalt;
            _userService.Create(userCreationDto);

            return Created("", GetResponse(true, "تم التسجيل بنجاح "));
        }

        [HttpPost("Login")]
        public IActionResult Login(UserLoginDto userLoginDto)
        {
            var user = _userService.GetUserByUserName(userLoginDto.UserName);
            if (user == null)
                return Unauthorized();

            //if (!_userService.VerifyPasswordHash(userLoginDto.Password, user.PasswordHash, user.PasswordSalt))
            //    return Unauthorized();

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_config.GetSection("AppSettings:TokenSigningKey").Value);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("UserId",user.Id.ToString()),
                    new Claim("Name",user.Name.ToString()),
                    new Claim("Phone",user.PhoneNumber.ToString())
               }),

                Expires = DateTime.UtcNow.AddDays(360),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return Ok(new { IsSuccess = true, Data = tokenHandler.WriteToken(token) });
        }

        [HttpGet("GetAuthUser")]
        [Authorize]
        public IActionResult GetAuthUser()
        {
            int userId = UserId;
            var user = _userService.GetUserById(userId);
            if (user == null)
                return Unauthorized();
            return Ok(new { IsSuccess = true, Data = user });
        }

        [HttpPost]
        [Route("forgetPassword")]
        public ActionResult ForgetPassword(ForgetPasswordRequestDTO forgetPasswordRequest)
        {
            var user = _userService.GetUserByUserName(forgetPasswordRequest.UserName);

            if (user == null)
            {
                return BadRequest(GetResponse(false, "اسم المستخدم غير موجود"));
            }

            var resetPasswordModel = _mapper.Map<ForgetPasswordRequestModel>(forgetPasswordRequest);
            var isSucceded =  _userService.ForgetPassword(resetPasswordModel);

            return Ok(GetResponse(isSuccess: true, data: isSucceded));
        }

        [HttpPost]
        [Route("validateOTP")]
        public IActionResult ValidateOTP(ValidateOTPRequestDTO validateOTPRequest)
        {
            var otpModel = _mapper.Map<ValidateOTPModel>(validateOTPRequest);

            var isSucceded = _userService.ValidateOTP(otpModel);

            return Ok(GetResponse(isSucceded, data:isSucceded));
        }
        [HttpPost]
        [Route("resetPassword")]
        public IActionResult ResetPassword(ResetPasswordRequestDTO resetPasswordRequest)
        {
            var resetPasswordModel = _mapper.Map<ResetPasswordDto>(resetPasswordRequest);

            var isSucceded = _userService.ResetPassword(resetPasswordModel);

            return Ok(GetResponse(true, data:isSucceded));
        }


        [HttpPost]
        [Route("updatePassword")]
        public IActionResult UpdatePassword(UpdatePasswordRequestDTO resetPasswordRequest)
        {
            var resetPasswordModel = _mapper.Map<UpdatePasswordRequestModel>(resetPasswordRequest);
            resetPasswordModel.UserId = UserId;

            var isSucceded = _userService.UpdatePassword(resetPasswordModel);

            return Ok(GetResponse(true, data: isSucceded));
        }

        private IApiResponse GetResponse(bool isSuccess = true, string message = "", object data = null)
        {
            return new ApiResponse
            {

            };
        }

    }
}
