using System.ComponentModel.DataAnnotations;

namespace Dimah.Core.Application.Dtos.Accounts
{
    public class UpdateUserProfileDto
    {
        public Guid Id { get; set; }
        public string NewPassWord { get; set; }
        [Compare(nameof(NewPassWord), ErrorMessage = "كلمة المرور غير متطابقة")]
        public string ConfirmNewPassWord { get; set; }

        public string FullNameAr { get; set; }
        public string FullNameEn { get; set; }
        public string PhoneNumber { get; set; }
        [EmailAddress(ErrorMessage = "صيغة البريد الالكتروني غير صحيحة")]
        public string Email { get; set; }
        public int? NationalityId { get; set; }
        public bool IsMale { get; set; }
    }
}
