using System;

namespace Methods_LabNEx_CalcRect
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double result = Solve(width, height);
            Console.WriteLine(result);
        }

        static double Solve(double width,double height)
        {
            return width * height;
        }
    }
}
