using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageListener
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter when the server is running.");
            Console.ReadKey();

            Listener listener = new Listener();
            listener.Open();

            Console.WriteLine("Done, press enter to exit");
            Console.ReadKey();
            listener.Dispose();
        }
    }
}
