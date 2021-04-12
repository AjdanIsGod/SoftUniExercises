using System;

namespace Methods_LabNEx_MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Solve(text);
        }

        private static void Solve(string text)
        {
            if (text.Length%2!=0)
            {
                int indexOfMidChar = text.Length / 2;
                char midChar = text[indexOfMidChar];
                Console.WriteLine(midChar);
            }
            else
            {
                int indexOfMidChar = text.Length / 2;
                char firstChar = text[indexOfMidChar-1];
                char secondChar = text[indexOfMidChar];
                Console.Write($"{firstChar}{secondChar}");
                
            }
        }
    }
}
