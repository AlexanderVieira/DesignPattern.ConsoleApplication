using System;

namespace AVS.DesignPatterns.Creational.MethodFactory
{
    // Concrete Product
    public class SqLiteConnector : DbConnector
    {
        public SqLiteConnector(string connectionString) : base(connectionString)
        {
            ConnectionString = connectionString;
        }

        public override Connection Connect()
        {
            Console.WriteLine("Conectando ao banco SqLite...");
            var connection = new Connection(ConnectionString);
            connection.Open();

            return connection;
        }
    }
}