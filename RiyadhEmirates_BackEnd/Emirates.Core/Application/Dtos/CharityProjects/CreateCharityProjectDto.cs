
namespace Dimah.Core.Application.Dtos
{
    public class CreateCharityProjectDto
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public int CharityId { get; set; }
        public int ProjectTypeId { get; set; }
        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }
        public double ProjectCost { get; set; }
        public string ProjectLocation { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; }
    }
}
