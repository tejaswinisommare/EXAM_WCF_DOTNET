using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClient
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ServiceReference1.ServiceClient O = new ServiceReference1.ServiceClient();
             Console.WriteLine(O.Hello());

             Console.WriteLine(O.abc(2));
             Console.ReadLine();*/

           /* //oneway method if method is void
            ServiceReference1.ServiceClient obj = new ServiceReference1.ServiceClient();
            Console.WriteLine("B");
            obj.Hello2(); //IsOneWay=True
            Console.WriteLine("A");
            Console.ReadLine();*/



            //Async  code
            ServiceReference1.ServiceClient obj = new ServiceReference1.ServiceClient();
            //Console.WriteLine(obj.Hello() );
            Console.WriteLine("B");
            obj.HelloCompleted += Obj_HelloCompleted;
            obj.HelloAsync();
            Console.WriteLine("A");
            Console.ReadLine();
        }

        private static void Obj_HelloCompleted(object sender, ServiceReference1.HelloCompletedEventArgs e)
        {
            Console.WriteLine(e.Result);
        }
    }
}
