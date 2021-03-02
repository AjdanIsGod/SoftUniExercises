using System;

namespace Methods_LabNEx_Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Solve(text,a,b);
        }

        private static void Solve(string a, int b , int c)
        {
            if (a == "add")
            {
                Console.WriteLine(b+c);
            }
            else if (a == "multiply") 
            {
                Console.WriteLine(b*c);
            }
            else if (a=="subtract")
            {
                Console.WriteLine(b-c);
            }
            else if (a=="divide")
            {
                Console.WriteLine(b/c);
            }
        }
    }
}
