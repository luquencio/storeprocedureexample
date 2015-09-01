using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreExample
{
    class TestConnection
    {

        public static void Run() {
            var Example = new Connection();
            Example.Connect();
            Example.Close();
            Console.ReadKey();
 
        }
    }
}
