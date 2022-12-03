
namespace Dimah.Core.Application.Response
{
    public interface IApiResponse
    {
        bool IsSuccess { get; set; }
        string Message { get; set; }
        object Data { get; set; }
    }
}
