
using System.ComponentModel.DataAnnotations;

namespace Dimah.Core.Application.Dtos
{
    public class CreateUserDto
    {
        [Required(ErrorMessage = "اسم المستخدم الزامي")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "كلمة المرور الزامية")]
        public string PassWord { get; set; }
        [Required(ErrorMessage = "تأكيد كلمة المرور الزامية")]
        [Compare(nameof(PassWord), ErrorMessage = "كلمة المرور غير متطابقة")]
        public string ConfirmPassWord { get; set; }

        public string FullNameAr { get; set; }
        public string FullNameEn { get; set; }
        public string PhoneNumber { get; set; }
        [EmailAddress(ErrorMessage ="صيغة البريد الالكتروني غير صحيحة")]
        public string Email { get; set; }
        public int? NationalityId { get; set; }
        public bool IsMale { get; set; }
    }
}
