using System;

namespace CSharp_Assignment_Q3_FloatBinaryAddition
{
    internal class UserInputDynamicLayout
    {
        private readonly BinaryConverter converter;
        private readonly FloatAdder adder;

        public UserInputDynamicLayout()
        {
            converter = new BinaryConverter();
            adder = new FloatAdder();

            bool continueProgram = true;

            while (continueProgram)
            {
                try
                {
                    Console.Write("Enter first float number: ");
                    float n = Convert.ToSingle(Console.ReadLine());

                    Console.Write("Enter second float number: ");
                    float m = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Binary of first number: " + converter.FloatToBinary(n));
                    Console.WriteLine("Binary of second number: " + converter.FloatToBinary(m));

                    float sum = adder.Add(n, m);

                    Console.WriteLine("Binary sum: " + converter.FloatToBinary(sum));
                    Console.WriteLine("Float result of addition: " + sum);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter numeric values.");
                }

            label:
                Console.WriteLine("\nPress 1 to continue, Press 0 to exit:");
                string choice = Console.ReadLine();

                if (choice == "0")
                {
                    Console.WriteLine("Exiting program. Goodbye!");
                    continueProgram = false;
                }
                else if (choice != "1")
                {
                    Console.WriteLine("Invalid choice.");
                    goto label;
                }

                Console.WriteLine(); // Blank line for readability
            }
        }
    }
}
