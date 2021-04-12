using System;

namespace Methods_LabNEx_SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(Solve(a,b,c));
        }

        private static int Solve(int a,int b,int c)
        {
            int answer = 0;
            if (a<b&&a<c)
            {
                answer = a;
            }
            else if (b<a&&b<c)
            {
                answer = b;
            }
            else
            {
                answer = c;
            }
            return answer;
        }
    }
}
