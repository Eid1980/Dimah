
namespace Dimah.Core.Application.Dtos
{
    public class GetPosterDetailsDto
    {
        public Guid Id { get; set; }
        public string TitleAr { get; set; }
        public string TitleEn { get; set; }
        public int Order { get; set; }
        public string ImageName { get; set; }
        public bool IsActive { get; set; }
    }
}
