using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rep = true;
            string userName;
            while (rep)
            {
                //Gets the name of the user
                Console.WriteLine("Please enter your name!");
                userName = Console.ReadLine();

                //Gets the input of the user
                Console.WriteLine("{0}, Please enter a number between 0 - 100: ", userName);
                int userInt = Validation(userName); //Brings it to a seperate method to check for validation.

                Console.Write("{0}, the number you entered was " + userInt, userName);

                //Checks for even numbers, then displays.
                if ((userInt) % 2 == 0)
                {
                    if (userInt >= 1 && userInt <= 25)
                    {
                        Console.WriteLine(", which is EVEN and less than 25!");
                    }
                    else if (userInt >= 26 && userInt <= 60)
                    {
                        Console.WriteLine(", which is EVEN while in between 26 and 60!");
                    }
                    else if (userInt > 60)
                    {
                        Console.WriteLine(", which is EVEN while in between 61 and 100!");
                    }
                }

                //Displays for odd numbers.
                else if (userInt >= 1 && userInt <= 25)
                {
                    Console.WriteLine(", which is ODD and less than 25!");
                }

                else if (userInt >= 26 && userInt <= 60)
                {
                    Console.WriteLine(", which is ODD while in between 26 and 60!");
                }

                else
                {
                    Console.WriteLine(", which is ODD while in between 61 and 100!");
                }

                //Presents user if they would like to continue or not.
                Console.WriteLine("Would you like to continue? (y/n)");

                bool success = true;

                string answer = Console.ReadLine();

                while (success)
                {
                    if (answer == "y" || answer == "Y")
                    {
                        Console.WriteLine("You chose to continue!");
                        rep = true;
                        success = false;
                    }
                    else
                    {
                        Console.WriteLine("Goodbye!");
                        return;
                    }
                }
            }
        }
        private static int Validation(string name) //Once again, the method that checks to make sure it is a number.
        {
            while (true)
            {
                string input = Console.ReadLine();
                bool success = int.TryParse(input, out int userInt);

                if (userInt < 0) //Any negative ints will be asked to input again.
                {
                    Console.WriteLine(userInt + " is a negative number!");
                    success = false;
                }

                if (userInt > 100) //Any ints over 100 will be asked to input again.
                {
                    Console.WriteLine(userInt + " is over the limit!");
                    success = false;
                }

                if (success) //If it doesn't fall into the previous IF statements, will continue with program.
                {
                    return userInt;
                }
                else //Anything but an int will require new input.
                {
                    Console.WriteLine("{0} Please try again! That was not a number between 0 - 100. ", name);
                }
            }
        }
    }
}