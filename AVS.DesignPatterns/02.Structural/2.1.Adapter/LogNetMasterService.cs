using System;

namespace AVS.DesignPatterns.Structural.Adapter
{
    // Adaptee class
    public class LogNetMasterService : ILoggerNetMaster
    {
        public void LogException(Exception exception)
        {
            Console.WriteLine("Log Customizado - " + exception.Message);
        }

        public void LogInfo(string message)
        {
            Console.WriteLine("Log Customizado - " + message);
        }
    }
}
