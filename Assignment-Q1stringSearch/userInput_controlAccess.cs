

namespace CSharp_Assignment_Questions_stringSearch
{
    //This class takes the dynamic inputs from the user & gives the control access...
    public class userInput_controlAccess
    {
        public userInput_controlAccess()
        {
            bool continueProgram = true;

            while (continueProgram)
            {
                Console.WriteLine("Enter a valid mainString:");
                string mainString = Console.ReadLine();

                if (!StringValidator.IsAlphabetOnly(mainString))
                {
                    Console.WriteLine("The string should contain only alphabets; no numeric or special symbols are allowed.");
                    goto RepeatPrompt1; // Go to end menu
                }

                RepeatPrompt2:
                Console.WriteLine("Enter a valid subString:");
                string searchString = Console.ReadLine();
          
                if (!StringValidator.IsAlphabetOnly(searchString))
                {
                    Console.WriteLine("The string should contain only alphabets; no numeric or special symbols are allowed.");
                    goto RepeatPrompt2;
                }

                StringSearcher.FindOccurrences(mainString, searchString);

            RepeatPrompt1:
                Console.WriteLine("\nPress 1 to continue, Press 0 to exit:");
                string choice = Console.ReadLine();

                if (choice == "0")
                {
                    continueProgram = false;
                    Console.WriteLine("Exiting program. Goodbye!");
                }
                else if (choice != "1")
                {
                    Console.WriteLine("Invalid choice.");
                }

                Console.WriteLine(); // Blank line for readability
            }
        }
    }
}
