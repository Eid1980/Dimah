using System;

namespace Dimah.Core.Domain.Entities
{
    public class ChartItem : AuditFullData<Guid>
    {
        public Guid CharityProjectId { get; set; }
        public int DonationValue { get; set; }
        public int DonationPeriod { get; set; }
        public int ChartItemStatusId { get; set; }

        public virtual CharityProject CharityProject { get; set; }
        public virtual ChartItemStatus ChartItemStatus { get; set; }
        public virtual User CreatedUser { get; set; }
        public virtual User ModifiedUser { get; set; }
    }
}
