using System;

namespace Methods_LabNEx_FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            FactorialDivision(a,b);
        }

        private static void FactorialDivision(double a,double b)
        {
            double aFactorial = 1;
            double bFactorial = 1;
            for (int i = 1; i <= a; i++)
            {
                aFactorial *= i;
            }
            for (int i = 1; i <= b; i++)
            {
                bFactorial *= i;
            }
            double result = aFactorial / bFactorial;
            Console.WriteLine(String.Format("{0:0.00}", result));
        }
    }
}
