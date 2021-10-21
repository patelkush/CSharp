using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            // Run GetAppInfo function to get info
            GetAppInfo();

            // Ask for User name and greet!!
            GreetUser();

            while (true)
            {   
                // Init correct number
                //int correctNumber = 7;

                // Create new random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get user's input
                    string input = Console.ReadLine();

                    // Make sure its a number

                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number");

                        //Keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number try again");
                    }
                }

                // Print error message
                PrintColorMessage(ConsoleColor.Yellow, "Correct!!! You guessed it");

                // Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            //string name = "Kush Patel";
            //int age = 26;

            // START HERE
            //Console.WriteLine("Hello " + name);
            //Console.WriteLine("{0} is {1}", name, age);

            //Set app vars

            string appName = "Number Guesses";
            string appVersion = "1.0.0";
            string appAuthor = "Kush Patel";

            // Changer text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text Color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your Name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game...", inputName);
        }

        // Print color message

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Changer text color
            Console.ForegroundColor = color;

            // Tell user its not a number
            Console.WriteLine(message);

            // Reset text Color
            Console.ResetColor();
        }
    }
}
