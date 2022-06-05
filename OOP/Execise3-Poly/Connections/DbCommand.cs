using System;

namespace Connections
{
    public class DbCommand
    {
        private DbConnection _connection;
        private string _instruction;
        public DbCommand(DbConnection connection, string instruction)
        {
            if (connection == null || instruction == null || instruction == "")
            {
                throw new InvalidOperationException("Error, check connection and/or instuction");
            }
            _connection = connection;
            _instruction = instruction;
        }

        public void Execute()
        {
            _connection.OpenConnection();
            Console.WriteLine("Run: " + _instruction + " on " + _connection.ConnectionString);
            _connection.CloseConnection();
        }
    }
}
