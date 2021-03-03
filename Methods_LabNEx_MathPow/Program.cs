using System;

namespace Methods_LabNEx_MathPow
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());
            double result = Solve(num, pow);
        }

        private static double Solve(double num,double pow)
        {
            double result = 0;
            result = Math.Pow(num, pow);
            return result;
        }
    }
}
