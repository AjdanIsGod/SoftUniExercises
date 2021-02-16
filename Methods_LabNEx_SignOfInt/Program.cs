using System;

namespace Methods_LabNEx_SignOfInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            solve(a);
        }

        private static void solve(int a)
        {
            if (a>0)
            {
                Console.WriteLine($"The number {a} is positive.");
            }
            else if(a<0)
            {
                Console.WriteLine($"The number {a} is negative.");
            }
            else if (a==0)
            {
                Console.WriteLine($"The number {a} is zero.");
            }
        }
    }
}
