
namespace Dimah.Core.Application.Dtos
{
    public class GetDailyRequestDetailsListDto
    {
        public string Day { get; set; }
        public int DonationValue { get; set; }
        public string IsPayed { get; set; }
        public string Sms { get; set; }
    }
}
