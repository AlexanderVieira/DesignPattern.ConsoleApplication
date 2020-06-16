namespace AVS.DesignPatterns.Creational.MethodFactory
{
    // Concrete Creator
    public class SqLiteFactory : DbFactory
    {
        // Factory Method
        public override DbConnector CreateConnector(string connectionString)
        {
            return new SqLiteConnector(connectionString);
        }
    }
}