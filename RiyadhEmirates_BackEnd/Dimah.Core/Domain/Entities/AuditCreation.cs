
namespace Dimah.Core.Domain.Entities
{
    public class AuditCreation<T>
    {
        public T Id { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
