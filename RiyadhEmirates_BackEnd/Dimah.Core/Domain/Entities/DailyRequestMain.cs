
namespace Dimah.Core.Domain.Entities
{
    public class DailyRequestMain
    {
        public DailyRequestMain()
        {
            this.DailyRequestDetails = new HashSet<DailyRequestDetail>();
        }
        public Guid Id { get; set; }
        public int DonationValue { get; set; }
        public int DonationPeriod { get; set; }
        public string ActForName { get; set; }
        public string ActForMobile { get; set; }
        public DateTime StartDate { get; set; }
        public int DailyRequestStatusId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual User CreatedUser { get; set; }
        public virtual ICollection<DailyRequestDetail> DailyRequestDetails { get; set; }
        
    }
}
