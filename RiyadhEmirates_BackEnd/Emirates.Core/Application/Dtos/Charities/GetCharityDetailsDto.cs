
namespace Dimah.Core.Application.Dtos
{
    public class GetCharityDetailsDto
    {
        public int Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }

        public List<GetCharityProjectListDto> CharityProjectList { get; set; }

    }
}
