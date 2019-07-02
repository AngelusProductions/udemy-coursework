using System;
using System.Threading;

namespace Databases
{
    public abstract class DbConnection
    {
        protected DbConnection(string connectionString)
        {
            _ = string.IsNullOrEmpty(connectionString) ?
                throw new NullReferenceException()
                 : ConnectionString = connectionString;
        }

        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public abstract void Open();
        public abstract void Close();
        public string GetStatus() { return _open ? "open" : "closed"; }
        public bool _open;
    }

    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString) {}
        public override void Open()
        {
            var startTime = DateTime.Now; var random = new Random(); 
            Thread.Sleep(random.Next(3000)); _open = true;
            Timeout = DateTime.Now - startTime;
        }
        public override void Close () { _open = false; Timeout = TimeSpan.Zero; }
    }


    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString) {}
        public override void Open()
        {
            var startTime = DateTime.Now; var random = new Random();
            Thread.Sleep(random.Next(3000)); _open = true;
            Timeout = DateTime.Now - startTime;
        }
        public override void Close() { _open = false; Timeout = TimeSpan.Zero; }
    }

}
