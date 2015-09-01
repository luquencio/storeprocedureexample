using System;
using Oracle.DataAccess.Client;

namespace StoreExample
{
    class Connection 
    {

        OracleConnection connection;

        String ConnectionString;

        public void Connect() {

            connection = new OracleConnection();
            connection.ConnectionString = "User Id=SYSTEM;Password=oracle";
            ConnectionString = connection.ConnectionString;
            connection.Open();
          //  Console.WriteLine("Connection up... " + connection.ServerVersion + " " + connection.ServiceName);
        }

        public string GetConnectionString() {
            String connection = "User Id=SYSTEM;Password=oracle";
            return connection;
        }


        public void Close() {
            connection.Close();
            connection.Dispose();
        }

    }
       
}
