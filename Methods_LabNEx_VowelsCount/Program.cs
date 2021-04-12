using System;

namespace Methods_LabNEx_VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            Solve(text);
        }

        private static void Solve(string userInput)
        {
            int counter = 0;
            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i]=='a'||userInput[i]=='e'||userInput[i]=='i'||userInput[i]=='o'||userInput[i]=='u')
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
