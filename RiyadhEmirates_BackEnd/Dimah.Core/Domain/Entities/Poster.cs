
namespace Dimah.Core.Domain.Entities
{
    public class Poster : AuditFullData<Guid>
    {
        public string TitleAr { get; set; }
        public string TitleEn { get; set; }
        public int Order { get; set; }
        public string ImageName { get; set; }
        public bool IsActive { get; set; }

        public virtual User CreatedUser { get; set; }
        public virtual User ModifiedUser { get; set; }
    }
}
