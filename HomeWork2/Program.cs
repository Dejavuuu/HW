using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
			/*
***Homework Assignment 2:

1. Create a console program  (choose .net framework)

2. Create some code in the Main Method() that:
	a. Shows a console message "sup from while loop" 5 times (using a while loop).
	b. Shows a console message "sup from for loop" 2 times (using for loop)
	c. Show a console message "sup once from do-while loop"
		1. Use a bool variable called runOnce.  Set this to true initially.
		2. set runOnce = false inside the do-while loop"
		3. Play around with what happens when you change the initial value of runOnce (toggle between true and false)



3. Commit and push to GitHub remote repo.
*/

			int begin = 0;

			while (begin < 6)
			{
				begin++;
				System.Console.WriteLine("sup from while loop");
			}

			//

			//int message = 0;

			for (int message = 0; message < 2; message = message + 1)
			{

				System.Console.WriteLine("sup from for loop");
			}

			//

			bool runOnce = true;

			do
			{

				System.Console.WriteLine("sup once from do-while loop");
			} while (runOnce == false);

			while (runOnce)

				//

				runOnce = false; //not declaring, resetting value

			do
			{

				System.Console.WriteLine("sup once from do-while loop");
			} while (runOnce == true);

			Console.ReadKey();
		}
    }
}
