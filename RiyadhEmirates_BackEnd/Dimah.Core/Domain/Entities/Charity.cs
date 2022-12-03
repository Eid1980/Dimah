
namespace Dimah.Core.Domain.Entities
{
    public class Charity : AuditFullData<int>
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }

        public virtual User CreatedUser { get; set; }
        public virtual User ModifiedUser { get; set; }
        public virtual ICollection<CharityProject> CharityProjects { get; set; }
    }
}
