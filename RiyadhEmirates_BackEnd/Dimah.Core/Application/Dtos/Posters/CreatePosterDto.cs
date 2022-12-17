
namespace Dimah.Core.Application.Dtos
{
    public class CreatePosterDto
    {
        public string TitleAr { get; set; }
        public string TitleEn { get; set; }
        public int Order { get; set; }
        public string ImageName { get; set; }
        public bool IsActive { get; set; }
    }
}
