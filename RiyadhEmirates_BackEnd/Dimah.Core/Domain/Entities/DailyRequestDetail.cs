
namespace Dimah.Core.Domain.Entities
{
    public class DailyRequestDetail
    {
        public Guid Id { get; set; }
        public Guid DailyRequestMainId { get; set; }
        public DateTime Day { get; set; }
        public bool IsPayed { get; set; }

        public virtual DailyRequestMain DailyRequestMain { get; set; }
    }
}
