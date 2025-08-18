using System;

namespace CSharp_Assignment_Q2_maximumProductFinder
{
    public class UserInputDynamicLayout
    {
        public UserInputDynamicLayout()
        {
            ProductCalculator calculator = new ProductCalculator();
            bool continueProgram = true;

            while (continueProgram)
            {
                try
                {
                    Console.WriteLine("Enter a number: ");
                    long number = Convert.ToInt64(Console.ReadLine());

                    int result = calculator.FindMaxProduct(number);
                    if (result != -1)
                        Console.WriteLine("Maximum product of 4 consecutive digits: " + result);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value.");
                }

                // Ask user whether to continue
                while (true)
                {
                    Console.WriteLine("\nPress 1 to continue, Press 0 to exit:");
                    string choice = Console.ReadLine();

                    if (choice == "0")
                    {
                        continueProgram = false;
                        Console.WriteLine("Exiting program. Goodbye!");
                        break;
                    }
                    else if (choice == "1")
                    {
                        break; // Go to next loop iteration
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Try again.");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
