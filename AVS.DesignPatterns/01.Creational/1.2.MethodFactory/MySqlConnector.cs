namespace AVS.DesignPatterns.Creational.MethodFactory
{
    public class MySqlConnector : DbConnector
    {
        public MySqlConnector(string connectionString) : base(connectionString)
        {
            ConnectionString = connectionString;
        }

        public override Connection Connect()
        {
            System.Console.WriteLine("Conectando ao banco MySQL...");
            var connection = new Connection(ConnectionString);
            connection.Open();

            return connection;
        }
    }
}