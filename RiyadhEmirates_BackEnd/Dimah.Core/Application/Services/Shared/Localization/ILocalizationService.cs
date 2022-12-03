using System.Globalization;

namespace Dimah.Core.Application.Services.Shared
{
    public interface ILocalizationService
    {
        string GetCurrentCultureName { get; }
        string GetCurrentUICultureName { get; }
        CultureInfo GetCurrentCulture { get; }
        CultureInfo GetCurrentUICulture { get; }
    }
}
