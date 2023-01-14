
namespace Dimah.Core.Application.Dtos
{
    public class GetDailyRequestListDto
    {
        public Guid Id { get; set; }
        public int DonationValue { get; set; }
        public int DonationPeriod { get; set; }
        public int DailyRequestStatusId { get; set; }
        public string ActForName { get; set; }
        public string ActForMobile { get; set; }
        public string StartDate { get; set; }
        public int PayedCount { get; set; }
        public int NotPayedCount { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
