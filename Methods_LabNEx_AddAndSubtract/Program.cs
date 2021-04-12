using System;

namespace Methods_LabNEx_AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int addition = Add(a, b);
            int subtraction = Subtract(addition, c);
            Console.WriteLine(subtraction);
        }

        private static int Subtract(int a,int b)
        {
            return a - b;
        }

        private static int Add(int a,int b)
        {
            return a + b;
        }
    }
}
