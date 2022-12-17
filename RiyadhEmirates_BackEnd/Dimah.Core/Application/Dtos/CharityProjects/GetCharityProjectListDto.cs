
namespace Dimah.Core.Application.Dtos
{
    public class GetCharityProjectListDto
    {
        public Guid Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string CharityName { get; set; }
        public string ProjectTypeName { get; set; }
        public double ProjectCost { get; set; }
        public bool IsActive { get; set; }
    }
}
