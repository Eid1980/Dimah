
namespace Dimah.Core.Application.Dtos
{
    public class RequestProfileDto
    {
        public int CurrentBalance { get; set; }
        public int CurrentDayDonation { get; set; }
        public int AllDonation { get; set; }
        public List<GetDailyRequestListDto> PayedRequests { get; set; }
        public List<GetDailyRequestListDto> NewRequests { get; set; }
        public List<GetDailyRequestListDto> FinishedRequests { get; set; }
    }
}
