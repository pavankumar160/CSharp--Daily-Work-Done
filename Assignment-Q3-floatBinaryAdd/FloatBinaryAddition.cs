using System.Text;

namespace CSharp_Assignment_Q3_FloatBinaryAddition
{
    public class BinaryConverter
    {
        public string FloatToBinary(float number)
        {
            int integerPart = (int)number;
            float fractionalPart = number - integerPart;

            // Integer part to binary
            StringBuilder intBinary = new StringBuilder();
            if (integerPart == 0)
                intBinary.Append("0");
            else
            {
                while (integerPart > 0)
                {
                    intBinary.Insert(0, integerPart % 2);
                    integerPart /= 2;
                }
            }

            // Fractional part to binary (limit 10 bits)
            StringBuilder fracBinary = new StringBuilder();
            int precision = 10;
            while (fractionalPart > 0 && precision > 0)
            {
                fractionalPart *= 2;
                int digit = (int)fractionalPart;
                fracBinary.Append(digit);
                fractionalPart -= digit;
                precision--;
            }

            return intBinary + "." + fracBinary;
        }
    }

    public class FloatAdder
    {
        public float Add(float a, float b)
        {
            return a + b;
        }
    }
}
