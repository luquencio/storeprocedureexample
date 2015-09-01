using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//using System.Data.OracleClient;
using Oracle.DataAccess.Client;

namespace StoreExample
{
    class Employee
    {

        public void RawQuery(String Query) {

            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = "User Id=SYSTEM;Password=oracle";

            OracleDataReader rdr;
            try
            {
                conn.Open();
                //OracleCommand cmd = new OracleCommand("select * from employee", conn);
                OracleCommand cmd = new OracleCommand(Query, conn);
                rdr = cmd.ExecuteReader();
                int rdr_size = (int)rdr.VisibleFieldCount;
        
                int n = 0;
                while (rdr.Read())
                {
                    n = 0;
                    while (n < rdr_size)
                    {
                        Console.Write("{0,-15} ",rdr[n]);
                        n++;
                    }

                    Console.WriteLine();
                }

                conn.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }        
        }

        
        public void GetAllEmployees() {

            RawQuery("select * from hr.employees");
        }


        public void foo() {
            RawQuery("select last_name,job_id,department_id,hire_date from hr.employees");
        }
    
    }
}