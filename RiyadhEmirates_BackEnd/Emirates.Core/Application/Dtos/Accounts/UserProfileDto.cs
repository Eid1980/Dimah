
namespace Dimah.Core.Application.Dtos.Accounts
{
    public class UserProfileDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FullNameAr { get; set; }
        public string FullNameEn { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsMale { get; set; }
        public int? NationalityId { get; set; }
        public string NationalityName { get; set; }
        public UploadedFileBase64Dto Image { get; set; }

    }
}
