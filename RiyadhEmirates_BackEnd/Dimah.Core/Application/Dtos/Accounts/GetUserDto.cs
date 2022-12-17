
namespace Dimah.Core.Application.Dtos
{
    public class GetUserDto
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string FullNameAr { get; set; }
        public string FullNameEn { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public string GenderName { get; set; }
        public string NationalityName { get; set; }

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool IsEmployee { get; set; }
        public bool IsActive { get; set; }
        public string OTP { get; set; }
    }
}
