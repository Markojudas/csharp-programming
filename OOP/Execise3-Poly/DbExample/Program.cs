using System;
using Connections;

namespace DbExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string sqlString = "sqlConnection";
            string oraclestring = "oracleConnection";
            string instructions ="SELECT * FROM emplyee";

            var sqlConnect = new SqlConnection(sqlString);
            var oracleConnect = new OracleConnection(oraclestring);

            var command = new DbCommand(sqlConnect, instructions);
            command.Execute();

            var command2 = new DbCommand(oracleConnect, instructions);
            command2.Execute();

            
        }
    }
}
