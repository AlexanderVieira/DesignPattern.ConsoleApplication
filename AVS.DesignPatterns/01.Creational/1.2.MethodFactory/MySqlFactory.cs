namespace AVS.DesignPatterns.Creational.MethodFactory
{
    // Concrete Creator
    public class MySqlFactory : DbFactory
    {
        // Factory Method
        public override DbConnector CreateConnector(string connectionString)
        {
            return new MySqlConnector(connectionString);
        }
    }
}