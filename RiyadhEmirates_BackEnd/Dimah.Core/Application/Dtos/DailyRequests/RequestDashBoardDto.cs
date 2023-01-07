
namespace Dimah.Core.Application.Dtos
{
    public class RequestDashBoardDto
    {
        public int CurrentBalance { get; set; }
        public int RemainingBalance { get; set; }
        public int CurrentDayDonation { get; set; }
        public int DonationPersonCount { get; set; }

        public List<GetDailyRequestListDto> PayedRequests { get; set; }
        public List<GetDailyRequestListDto> FinishedRequests { get; set; }
    }
}
