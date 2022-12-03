
namespace Dimah.Core.Domain.Entities
{
    public class ProjectType : AuditFullData<int>
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public bool IsActive { get; set; }

        public virtual User CreatedUser { get; set; }
        public virtual User ModifiedUser { get; set; }
        public virtual ICollection<CharityProject> CharityProjects { get; set; }
    }
}
