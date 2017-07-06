using System;

namespace Third
{
    public class Progprog
    {
        public static string MixedFraction(string s)
        {
            Int32 top;
            Int32 bottom;
            Int32 divided = 0;
            string result = "";
            string[] splitting = s.Split('/');
            if (splitting.Length == 2)
            {
                try
                {
                   top = Convert.ToInt32(splitting[0]);
                   bottom = Convert.ToInt32(splitting[1]);
                }
                catch(Exception e)
                {
                    Console.WriteLine("Bad!" + e);
                    return("Bad! Not Number!");
                }
 
                if (bottom != 0)
                {
                    if (top >= bottom)
                    {
                        divided = top / bottom;
                        top -= (bottom * divided);
                    }
                }
                else
                {
                   throw new DivideByZeroException();
                }
 
                for (int a = 2; a <= top; a++)
                {
                    if ((top % a == 0) && (bottom % a == 0))
                    {
                        top /= a;
                        bottom /= a;
                        break;
                    }
                }
 
                var spa1 = "";
                var spa2 = "";
 
                if ((divided >= 0) && (top == 0))
                {
                    spa1 = divided.ToString();
                }
                else if (divided > 0)
                {
                    spa1 = divided.ToString() + " ";
                }
                if (top != 0)
                {
                    spa2 = top.ToString() + "/" + bottom.ToString();
                }
                result = spa1 + spa2;
            }
            return result;
        }
 
        static void Main(string[] args)
        {
            Console.WriteLine(MixedFraction("10/1"));
        }
    }
}
}
