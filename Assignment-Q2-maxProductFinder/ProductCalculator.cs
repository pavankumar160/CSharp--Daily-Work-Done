using System;

namespace CSharp_Assignment_Q2_maximumProductFinder
{
    //Logic... This class finds the maxProduct
    public class ProductCalculator
    {
        public int FindMaxProduct(long number)
        {
            if (number <= 999)
            {
                Console.WriteLine("Number must be greater than 999.");
                return -1;
            }

            string digits = number.ToString();
            int maxProduct = 0;

            for (int i = 0; i <= digits.Length - 4; ++i)
            {
                int digit1 = digits[i] - '0';
                int digit2 = digits[i + 1] - '0';
                int digit3 = digits[i + 2] - '0';
                int digit4 = digits[i + 3] - '0';

                int product = digit1 * digit2 * digit3 * digit4;

                if (product > maxProduct)
                {
                    maxProduct = product;
                }
            }

            return maxProduct;
        }
    }
}
