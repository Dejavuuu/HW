using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
	public class HW3
	{

		public static void Main(String[] args)
		{

			Console.WriteLine("This program runs 3 different funtions.  Please pick from the following:");
			Console.WriteLine("1: n-times loop, 2: random loop, 3: user-option loop");
			Console.WriteLine("please type 1, 2, or 3 and press enter.");

			int choice = 0;
			choice = int.Parse(Console.ReadLine());  //if anything else than an integer is entered an exception will occur.

			if (choice == 1)
			{
				Function1();
			}
			else if (choice == 2)
			{
				Function2();
			}
			else if (choice == 3)
			{
				Function3();
			}
			else
			{
				Console.WriteLine("You have entered an invalid selection");
			}

			Console.WriteLine("press any key to exit program.");
			Console.ReadKey();

		}
		public static void Function1()
		{
			Console.WriteLine("You selected Function 1 \n How many times do you want to see this loop?");
			int times = 0;
			times = int.Parse(Console.ReadLine());

			while(times > 0)
			{
				Console.WriteLine(":)");
				times--;
			} 

		}
		public static void Function2()
		{
			Console.WriteLine("You selected Function 2");
			Random rand = new Random();
			int randomNumber = rand.Next(0, 1000);

			int displayRandomNumber = randomNumber;
			while (randomNumber > 0)
			{
				
				Console.WriteLine(":)");
				randomNumber--;
			}
			Console.WriteLine(displayRandomNumber);

		}
		public static void Function3()
		{
			Console.WriteLine("You selected Function 3");
		}
	}
}