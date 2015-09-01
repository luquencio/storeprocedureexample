using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace StoreExample
{
    class Program 
    {
        static void Main(string[] args)
        {
            TestConnection.Run();
            Employee Emp = new Employee();
            //Emp.GetAllEmployees();
            Emp.foo();


            Console.ReadKey();
        }
    }
}
