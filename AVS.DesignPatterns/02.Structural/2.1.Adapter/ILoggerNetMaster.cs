using System;

namespace AVS.DesignPatterns.Structural.Adapter
{
    public interface ILoggerNetMaster
    {
        void LogInfo(string message);
        void LogException(Exception exception);
    }
}
