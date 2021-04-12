using System;

namespace Methods_LabNEx_CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            Solve(first,second);
        }

        private static void Solve(char first,char second)
        {
            int firstChar = Math.Min(first, second);
            int secondChar = Math.Max(first, second);
            for (int i = firstChar+1; i < secondChar; i++)
            {
                Console.Write((char)i+" ");
            }
        }
    }
}
