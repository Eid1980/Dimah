
namespace Dimah.Core.Application.Dtos
{
    public class CreateChartItemDto
    {
        public Guid CharityProjectId { get; set; }
        public int DonationValue { get; set; }
        public int DonationPeriod { get; set; }
        public int ChartItemStatusId { get; set; }
    }
}
