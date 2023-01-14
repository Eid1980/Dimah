
namespace Dimah.Core.Application.Dtos
{
    public class CreateDailyRequestDto
    {
        public int DonationValue { get; set; }
        public int DonationPeriod { get; set; }
        public string ActForName { get; set; }
        public string ActForMobile { get; set; }
        public DateTime? StartDate { get; set; }
    }
}
