namespace AVS.DesignPatterns.Structural.Adapter
{
    public class ExecutionAdapter
    {
        public static void Run()
        {
            var standardPayment = new TransactionService(new Logger());
            standardPayment.PerformTransaction();

            var customPayment = new TransactionService(new LogAdapter(new LogNetMasterService()));
            customPayment.PerformTransaction();
        }
    }
}
