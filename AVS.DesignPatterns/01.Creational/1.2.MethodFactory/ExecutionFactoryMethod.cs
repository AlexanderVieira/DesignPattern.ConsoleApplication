using System;

namespace AVS.DesignPatterns.Creational.MethodFactory
{
    public class ExecutionFactoryMethod
    {
        public static void Run()
        {
            var mysqlConn = DbFactory.Database(DataBase.MySQL)
                                     .CreateConnector("myConnStr")
                                     .Connect();

            mysqlConn.ExecuteCommand("select * myTabelaSql");
            mysqlConn.Close();

            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");

            var oracleConn = DbFactory.Database(DataBase.Oracle)
                                      .CreateConnector("myConnStr")
                                      .Connect();

            oracleConn.ExecuteCommand("select * myTabelaSql");
            oracleConn.Close();

            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");

            var sqliteConn = DbFactory.Database(DataBase.SqLite)
                .CreateConnector("myConnStr")
                .Connect();

            sqliteConn.ExecuteCommand("select * myTabelaSql");
            sqliteConn.Close();

            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");

            var sqlServerConn = DbFactory.Database(DataBase.SqlServer)
                .CreateConnector("myConnStr")
                .Connect();

            sqlServerConn.ExecuteCommand("select * myTabelaSql");
            sqlServerConn.Close();

            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");

        }
    }
}
