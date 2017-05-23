using System;

namespace Cipher
{
    class Program
    {

        public static string Encode(string input)
        {
            // Convert chars to Uppercase letters
            string input2 = input.ToUpper();
            // Convert to char array
            char[] convert1 = input.ToCharArray();
            // sub is used if a non-alphabetic char is parsed, then skip over it
            int sub = 1;
            // While there are chars in array start with 2nd char

            for (var a = 1; a < (convert1.Length - 1); a++)
            {
                // Get ASCII value of char
                int y = (int)convert1[a];
                // If non-alphabetic then increase sub and skip over
                if ((y < 65) || (y > 90))
                {
                    sub++;
                    continue;
                }
                else
                {
                    // Get number value of character
                    int numChar = (int)convert1[a];
                    // z is the ASCII value of previous letter
                    int z = ((int)convert1[a - sub] % 65);
                    // If new ASCII value is greater than Z
                    if ((numChar + z) > 90)
                    {
                        // Get new value of numChar
                        numChar = ((numChar % 90) + 64);
                    }
                    // Assign new value of numChar to char array
                    convert1[a] = (char)numChar;
                    // reset sub back to 1
                    sub = 1;
                }
               
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
