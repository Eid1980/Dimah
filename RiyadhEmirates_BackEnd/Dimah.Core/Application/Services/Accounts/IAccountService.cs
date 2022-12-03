using Dimah.Core.Application.Dtos;
using Dimah.Core.Application.Dtos.Accounts;
using Dimah.Core.Application.Response;

namespace Dimah.Core.Application.Services.Accounts
{
    public interface IAccountService
    {
        IApiResponse GetUserData(int id);
        IApiResponse GetCurrentUserRoles(int id);
        IApiResponse GetById(int id);
        IApiResponse GetAuthUser(int id);
        IApiResponse GetByUserName(string userName);
        IApiResponse GetByPhone(string phoneNumber);
        IApiResponse UserExist(string userName);
        IApiResponse Login(UserLoginDto userLoginDto);

        IApiResponse ForgetPassword(ForgetPasswordDto forgetPasswordDto);
        IApiResponse UpdatePassword(UpdatePasswordDto updatePasswordDto);
        IApiResponse ValidateOTP(ValidateOTPDto validateOTPDto);
        IApiResponse ResetPassword(ResetPasswordDto resetPasswordDto);
        IApiResponse Register(CreateUserDto createUserDto);
        IApiResponse UpdateUserProfile(UpdateUserProfileDto updateUserProfileDto);

        IApiResponse GetUserProfileData(int id);


        IApiResponse CreateEmployee(int userId);
        IApiResponse DeleteEmployee(int userId);
    }
}
