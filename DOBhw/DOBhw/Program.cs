using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOBhw
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user to enter birthday in mm/dd/yy format
            Console.WriteLine("Enter birthday (MM/DD/YY): ");

            //var rawData = Console.ReadLine();
            string rawData = Console.ReadLine();

            //
            DateTime dob = DateTime.Parse(rawData);

            Console.WriteLine("Age in years " + (DateTime.Now.Year - dob.Year));
            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
