using System;
using System.Linq;

namespace Methods_LabNEx_PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input!="END")
            {
                string reversed = Reversed(input);
                if (reversed!=input)
                {
                    Console.WriteLine("false");
                }
                else
                {
                    Console.WriteLine("true");
                }
                input = Console.ReadLine();
            }
        }
        public static string Reversed(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }
}
