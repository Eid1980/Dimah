
namespace Dimah.Core.Application.Dtos
{
    public class ProjectDetailsDto
    {
        public Guid Id { get; set; }
        public Guid CharityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double ProjectCost { get; set; }
        public string ProjectLocation { get; set; }
        public string Image { get; set; }

        public List<DimahProjectsListDto> RelatedProjects { get; set; }
    }
}
