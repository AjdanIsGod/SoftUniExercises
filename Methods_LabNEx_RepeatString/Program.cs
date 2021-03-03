using System;

namespace Methods_LabNEx_RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int reps = int.Parse(Console.ReadLine());
            Solve(text,reps);
        }

        private static void Solve(string text,int reps)
        {
            for (int i = 0; i < reps; i++)
            {
                Console.Write(text);
            }
        }
    }
}
