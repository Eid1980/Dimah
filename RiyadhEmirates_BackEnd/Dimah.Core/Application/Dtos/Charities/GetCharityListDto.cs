
namespace Dimah.Core.Application.Dtos
{
    public class GetCharityListDto
    {
        public Guid Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
    }
}
