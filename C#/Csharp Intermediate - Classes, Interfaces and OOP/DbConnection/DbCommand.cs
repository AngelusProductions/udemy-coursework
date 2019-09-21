using System;

namespace Databases
{
    public class DbCommand
    {
        public DbCommand(DbConnection connection, string instruction)
        {
            if (connection.Equals(null) || instruction.Equals(null)) throw new NullReferenceException();
            Connection = connection; Instruction = instruction;
        }

        public string Execute() { 
            Connection.Open(); Connection.Close();
            return $"Executed: {Instruction}"; }

        public DbConnection Connection { get; set; }
        public string Instruction { get; set; }
    }

}
