using Microsoft.Extensions.Configuration;
using Serilog;

namespace Dimah.InfraStructure.Interfaces.Logging
{
    public interface ISerilogHelper : ILoggerHelper<ILogger>
    {
        void TestStaticLogger();
        ILogger InitializeLogger(IConfigurationRoot configuration, string configurationSection);
    }
}
