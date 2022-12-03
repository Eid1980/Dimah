using System.Runtime.CompilerServices;

namespace Dimah.InfraStructure.Interfaces.Logging
{
    public interface ILoggerHelper<TLogger>
    {
        TLogger Logger { get; }

        void TestLogger();
        string GetContextInfoForLogging([CallerFilePath] string callerFilePath = null,
            [CallerMemberName] string callerMethodName = null,
            [CallerLineNumber] int callerLineNumber = 0);
    }
}
