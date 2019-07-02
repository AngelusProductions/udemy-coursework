using System.Threading;
using static System.Console;

namespace Databases
{
    class MainClass
    {
        public static void Main()
        {
            var sqlConn = new SqlConnection("password"); sqlConn.Open();
            WriteLine($"SQL Connection Timeout: {sqlConn.Timeout.TotalSeconds} seconds");
            Thread.Sleep(500); WriteLine($"SQL Connection Status: {sqlConn.GetStatus()}");

            var oracleConn = new SqlConnection("password"); oracleConn.Open();
            WriteLine($"Oracle Connection Timeout: {oracleConn.Timeout.TotalSeconds} seconds");
            Thread.Sleep(500); WriteLine($"Oracle Connection Status: {oracleConn.GetStatus()}");

            var sqlCommand = new DbCommand(sqlConn, "Select COUNT([Data]) FROM dbo.sqlDatabase");
            var oracleCommand = new DbCommand(sqlConn, "Select COUNT([Data]) FROM dbo.Oracledatabase");
            WriteLine(sqlCommand.Execute()); WriteLine(oracleCommand.Execute());
        }
    }
}
