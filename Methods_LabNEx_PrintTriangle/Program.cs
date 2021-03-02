using System;

namespace Methods_LabNEx_PrintTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            for (int i = 1; i <= k; i++)
            {
                Solve(1, i);
            }
            for (int i = k-1; i >= 1; i--)
            {
                Solve(1, i);
            }
        }

        private static void Solve(int start,int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
    }
}
