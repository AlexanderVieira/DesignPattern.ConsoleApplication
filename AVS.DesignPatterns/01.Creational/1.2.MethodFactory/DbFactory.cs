using System;

namespace AVS.DesignPatterns.Creational.MethodFactory
{
    // Abstract Creator
    public abstract class DbFactory
    {
        // Factory Method
        public abstract DbConnector CreateConnector(string connectionString);

        public static DbFactory Database(DataBase dataBase)
        {
            switch (dataBase)
            {
                case DataBase.MySQL:
                    return new MySqlFactory();                    
                case DataBase.SqLite:
                    return new SqLiteFactory();
                case DataBase.SqlServer:
                    return new SqlServerFactory();
                case DataBase.Oracle:
                    return new OracleFactory();
                default:
                    throw new ApplicationException("Banco de dados não reconhecido.");                    
            }
        }
    }
}
