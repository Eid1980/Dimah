using Dimah.Core.Application.Dtos;
using Dimah.Core.Application.Dtos.Accounts;
using Dimah.Core.Application.Response;

namespace Dimah.Core.Application.Services.Accounts
{
    public interface IAccountService
    {
        IApiResponse GetUserData(Guid id);
        IApiResponse GetCurrentUserRoles(Guid id);
        IApiResponse GetById(Guid id);
        IApiResponse GetAuthUser(Guid id);
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

        IApiResponse GetUserProfileData(Guid id);
        IApiResponse CreateEmployee(Guid userId);
        IApiResponse DeleteEmployee(Guid userId);
        bool IsUserInRoles(Guid userId, int[] roles);
    }
}
