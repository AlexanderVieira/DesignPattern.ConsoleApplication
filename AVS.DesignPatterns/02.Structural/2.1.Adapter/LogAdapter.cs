using System;

namespace AVS.DesignPatterns.Structural.Adapter
{
    // Adapter class
    public class LogAdapter : ILogger
    {
        private readonly ILoggerNetMaster _loggerNetMaster;

        public LogAdapter(ILoggerNetMaster loggerNetMaster)
        {
            _loggerNetMaster = loggerNetMaster;
        }

        public void Log(string message)
        {
            _loggerNetMaster.LogInfo(message);
        }

        public void LogError(Exception exception)
        {
            _loggerNetMaster.LogException(exception);
        }
    }
}
