
namespace Dimah.Core.Domain.Entities
{
    public class News : AuditFullData<Guid>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public string ImageName { get; set; }
        public bool IsActive { get; set; }
        public bool OpenComments { get; set; }

        public virtual User CreatedUser { get; set; }
        public virtual User ModifiedUser { get; set; }
        public virtual ICollection<NewsComment> NewsComments { get; set; }
    }
}
