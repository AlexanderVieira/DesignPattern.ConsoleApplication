namespace AVS.DesignPatterns.Creational.MethodFactory
{
    // Concrete Creator
    public class SqlServerFactory : DbFactory
    {
        // Factory Method
        public override DbConnector CreateConnector(string connectionString)
        {
            return new SqlServerConnector(connectionString);
        }
    }
}