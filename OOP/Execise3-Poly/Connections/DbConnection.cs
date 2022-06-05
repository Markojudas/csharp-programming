using System;

namespace Connections
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        
        //private TimeSpan Timeout { get; set; } not implemented

        protected bool isConnected;


        public DbConnection(string connectionString)
        {
            if(connectionString == null || connectionString == "")
            {
                throw new InvalidOperationException("Gotta pass a string, buddy");
            }
            this.ConnectionString = connectionString;
        }
        
        public abstract void OpenConnection();
        public abstract void CloseConnection();

        
    }
}
