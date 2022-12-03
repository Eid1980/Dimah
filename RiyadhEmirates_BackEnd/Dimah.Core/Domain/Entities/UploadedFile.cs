
namespace Dimah.Core.Domain.Entities
{
    public class UploadedFile : AuditFullData<Guid>
    {
        public string EntityId { get; set; }
        public string EntityName { get; set; }
        public string SubEntityName { get; set; }
        public string Name { get; set; }
        public string OriginalName { get; set; }
        public string Extention { get; set; }
        public bool IsActive { get; set; }

        public virtual User CreatedUser { get; set; }
        public virtual User ModifiedUser { get; set; }
    }
}
