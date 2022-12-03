

namespace Dimah.Core.Application.Response
{
    public class ApiResponse : IApiResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
