
namespace Dimah.Core.Domain.Entities
{
    public class ChartItemStatus
    {
        public int Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<ChartItem> ChartItems { get; set; }
    }
}
