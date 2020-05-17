using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class HWbirthday
{
        static void Main(string[] args)
        {
            // Prompt user to enter birthday in mm/dd/yy format
            Console.WriteLine("Enter birthday (MM/DD/YY): ");

            var rawData = Console.Readline();
            //
            string rawData = Console.ReadLine();
            
            //
            DateTime dob = Date.Time.Parse(rawData);

            // A specific date
            DateTime overlordDday = new DateTime(1944, 6, 6);

            // Output
            Console.WriteLine("D-Day (Overlord operation): " +
                              overlordDday.ToLongDateString() + ".");

            Console.WriteLine("age in years " +
                           (overlordDday.Year - DateTime.Now.Year) + ".");
            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
