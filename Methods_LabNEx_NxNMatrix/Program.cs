using System;

namespace Methods_LabNEx_NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Solve(n);
        }

        private static void Solve(int N)
        {
            for (int rows = 0; rows < N; rows++)
            {
                for (int columns = 0; columns < N; columns++)
                {
                    Console.Write(N + " ");
                }
                Console.WriteLine();
            }   
        }
    }
}
