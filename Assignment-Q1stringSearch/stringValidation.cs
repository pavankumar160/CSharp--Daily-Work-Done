
namespace CSharp_Assignment_Questions_stringSearch
{
   
    // This class Validates the string... Checks the User Entered String is Valid or Not...
    public static class StringValidator
    {
        public static bool IsAlphabetOnly(string input)
        {
            foreach (char c in input)
            {
                int ascii = (int)c;
                if (ascii != 32 && (ascii < 65 || ascii > 90) && (ascii < 97 || ascii > 122))
                {
                    return false;
                }
            }
            return true;
        }
    }
    
}
