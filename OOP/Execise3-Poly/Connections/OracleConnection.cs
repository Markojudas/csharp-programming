using System;

namespace Connections
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection (string connectionString)
        :base(connectionString){}

        public override void CloseConnection()
        {
            if (!isConnected)
            {
                throw new InvalidOperationException("No open connections");                
            }
            Console.WriteLine("Closing Oracle Connection");
            isConnected = false;
            
        }

        public override void OpenConnection()
        {
            if(isConnected)
            {
                throw new InvalidOperationException("Connection already open");                
            }
            Console.WriteLine("Opening Oracle Connection");
            isConnected = true;
        }
    }
}
