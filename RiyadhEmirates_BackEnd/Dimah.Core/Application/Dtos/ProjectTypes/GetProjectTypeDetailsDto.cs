
namespace Dimah.Core.Application.Dtos
{
    public class GetProjectTypeDetailsDto
    {
        public Guid Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string ImageName { get; set; }
        public bool IsActive { get; set; }
    }
}
