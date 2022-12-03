
namespace Dimah.Core.Domain.Entities
{
    public class AuditCreation<T>
    {
        public T Id { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
