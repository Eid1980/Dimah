
namespace Dimah.Core.Application.Dtos
{
    public class GetChartItemDetailsDto
    {
        public Guid Id { get; set; }
        public Guid CharityProjectId { get; set; }
        public string CharityProjectName { get; set; }
        public int DonationValue { get; set; }
        public int DonationPeriod { get; set; }
        public int ChartItemStatusId { get; set; }
    }
}
