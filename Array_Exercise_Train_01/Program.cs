using System;
using System.Linq;

namespace Array_Exercise_Train_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] train = new int[n];
            for (int i = 0; i < n; i++)
            {
                int people = int.Parse(Console.ReadLine());
                train[i] = people;
            }
            int sum = train.Sum();
            Console.WriteLine(string.Join(" ",train));
            Console.WriteLine(sum);
        }
    }
}
