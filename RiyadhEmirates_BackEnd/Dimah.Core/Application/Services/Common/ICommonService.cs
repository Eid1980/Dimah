using Dimah.Core.Application.Dtos;

namespace Dimah.Core.Application.Services.Common
{
    public interface ICommonService
    {
        Task SendEmailAsync(MailRequestDto mailRequest);
    }
}
