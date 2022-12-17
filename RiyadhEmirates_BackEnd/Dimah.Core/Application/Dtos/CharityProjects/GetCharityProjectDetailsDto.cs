
namespace Dimah.Core.Application.Dtos
{
    public class GetCharityProjectDetailsDto
    {
        public Guid Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public Guid CharityId { get; set; }
        public string CharityName { get; set; }
        public Guid ProjectTypeId { get; set; }
        public string ProjectTypeName { get; set; }
        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }
        public double ProjectCost { get; set; }
        public string ProjectLocation { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; }
    }
}
