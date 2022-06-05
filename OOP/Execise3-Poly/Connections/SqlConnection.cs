using System;

namespace Connections
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection (string connectionString)
        :base(connectionString){}

        public override void CloseConnection()
        {
            if (!isConnected)
            {
                throw new InvalidOperationException("No Open Connections");                
            }
            Console.WriteLine("Closing SQL Connection");
            isConnected = false;
        }

        public override void OpenConnection()
        {
            if(isConnected)
            {
                throw new InvalidOperationException("Connection already open");                
            }
            Console.WriteLine("Opening SQL Connection");
            isConnected = true;
            
        }
    }
}
