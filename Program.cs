using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            //can't figure out why 'Boolean canContinue = false' isn't printing
            bool canContinue = false;
            if (canContinue != true)
               
            {
                Console.WriteLine("Proceed...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You Shall Not Pass!");
                Console.ReadKey();
            }

            Console.WriteLine("Hello World");
            Console.ReadKey();




        }
    }
}
