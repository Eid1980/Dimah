
namespace Dimah.Core.Application.Dtos
{
    public class CurrentChartListDto
    {
        public Guid Id { get; set; }
        public string CharityProjectName { get; set; }
        public int DonationValue { get; set; }
        public int DonationPeriod { get; set; }
        public int DonationTotal { get; set; }
    }
}
