using System;

namespace Cipher
{
    public class Program
    {

        public static string Encode(string input)
        {
            if ((input != "") && (input != null))
            {
                // Char array to store new String
                char[] newString = new char[input.Length];
                // Convert chars to Uppercase letters
                string input2 = input.ToUpper();
                // Convert to char array
                char[] convert1 = input2.ToCharArray();
                // sub is used if a non-alphabetic char is parsed, then skip over it
                int sub = 1;
                int letter = 0;
                while (((convert1[letter] < 65) && (convert1[letter] > 32)) || (convert1[letter] > 90))
                {
                    newString[letter] = convert1[letter];
                    letter++;
                }
 
                newString[letter] = convert1[letter++];
                // While there are chars in array start with 2nd char
                for (var a = letter; a < convert1.Length; a++)
                {
                    // Get ASCII value of char
                    int y = (int)convert1[a];
                    // If non-alphabetic then increase sub and skip over
                    if ((y < 65) || (y > 90))
                    {
                        sub++;
                        newString[a] = (char)y;
                        continue;
                    }
                    else
                    {
                        // Get number value of character
                        //int numChar = (int)convert1[a];
                        // z is the ASCII value of previous letter
                        int z = ((int)convert1[a - sub] % 64);
                        // If new ASCII value is greater than Z
                        int w = y + z;
                        if (w > 90)
                        {
                            // Get new value of numChar
                            w = ((w % 90) + 64);
                        }
                        // Assign new value of numChar to char array
                        newString[a] = (char)w;
                        // reset sub back to 1
                        sub = 1;
                    }
                   
                }
               
                return new string(newString);
            }
            else
            {
                return string.Empty;
            }
        }
 
        public static string Decode(string input)
        {
            if ((input != "") && (input != null))
            {
                // Char array to store new String
                char[] newString = new char[input.Length];
                // Convert chars to Uppercase letters
                string input2 = input.ToUpper();
                // Convert to char array
                char[] convert1 = input2.ToCharArray();
                // sub is used if a non-alphabetic char is parsed, then skip over it
                int sub = 1;
                int letter = 0;
                while (((convert1[letter] < 65) && (convert1[letter] > 32)) || (convert1[letter] > 90))
                {
                    letter++;
                }
               
                for (var a = ++letter; a < convert1.Length; a++)
                {
                    // Get ASCII value of char
                    int y = (int)convert1[a];
                    //Console.WriteLine(y.ToString());
                    // If non-alphabetic then increase sub and skip over
                    if ((y < 65) || (y > 90))
                    {
                        sub++;
                        convert1[a] = (char)y;
                        continue;
                    }
                    else
                    {
                        // Get number value of character
                        //int numChar = (int)convert1[a];
                        // z is the ASCII value of previous letter
                        int z = ((int)convert1[a - sub] % 64);
                        // If new ASCII value is greater than Z
                        int w = y - z;
                        if (w < 65)
                        {
                            // Get new value of numChar
                            w = (91 - (65 - w));
                        }
                        // Assign new value of numChar to char array
                        convert1[a] = (char)w;
                        // reset sub back to 1
                        sub = 1;
                    }
                   
                }

                return new string(convert1);
            }
            else
            {
                return string.Empty;
            }
        }   

        static void Main(string[] args)
        {
            string x0 = Encode("");
 
            string x0a = Encode(null);
 
            string x1 = Encode("He1lo");
            Console.WriteLine(x1);
 
            string x2 = Decode("5DHG4GHJ-7G47-44E3-8IIE-3171860EG938");
            Console.WriteLine(x2);
            Console.WriteLine("5DDC4DDF-7A47-44D3-8EDA-3171860DC938");
 
            string x3 = Encode("5DDC4DDF-7A47-44D3-8EDA-3171860DC938");
            Console.WriteLine(x3);
            Console.WriteLine("5DHG4GHJ-7G47-44E3-8IIE-3171860EG938");
 
            string x4 = Encode("The quick brown fox jumps over the lazy dog");
            Console.WriteLine(x4);
            Console.WriteLine("TBM VLDLN MTGLK TUM HEHCI HKAW LBM QMAY CSV");
 
            string x5 = Decode("TBM VLDLN mTGLK TUM HEHCI HKAW LBM QMAY CSV");
            Console.WriteLine(x5);
            Console.WriteLine("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG");
        }
    }
}
