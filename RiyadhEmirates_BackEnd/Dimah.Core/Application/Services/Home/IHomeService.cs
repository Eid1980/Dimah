using Dimah.Core.Application.Response;
using System;

namespace Dimah.Core.Application.Services.Home
{
    public interface IHomeService
    {
        IApiResponse GetCharityProjects(Guid id);
        IApiResponse GetDimahTop4Projects();
        IApiResponse GetProjectDetails(Guid id);
    }
}
