
namespace CSharp_Assignment_Questions_stringSearch
{
    //Actual Logic.. String Comparision
    public static class StringSearcher
    {
        public static void FindOccurrences(string mainString, string searchString)
        {
            if (string.IsNullOrEmpty(mainString) || string.IsNullOrEmpty(searchString))
            {
                Console.WriteLine("Input strings cannot be null or empty.");
                return;
            }

            // Make both lowercase for case-insensitive comparison
            mainString = mainString.ToLower();
            mainString = mainString.TrimStart();
            searchString = searchString.ToLower();
            searchString = searchString.TrimStart();

            bool found = false;

            for (int i = 0; i <= mainString.Length - searchString.Length; i++)
            {
                int searchIndex = 0;
                bool isMatch = true;

                if (mainString[i] == searchString[searchIndex])
                {
                    searchIndex = 1;

                    for (int j = i + 1; searchIndex < searchString.Length && j < mainString.Length; j++)
                    {
                        if (mainString[j] != searchString[searchIndex])
                        {
                            isMatch = false;
                            break;
                        }
                        searchIndex++;
                    }

                    if (isMatch && searchIndex == searchString.Length)
                    {
                        Console.WriteLine($"The search string \"{searchString}\" found at index {i}");
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine($"The search string \"{searchString}\" was not found in the given string.");
            }
        }
    }

    

}