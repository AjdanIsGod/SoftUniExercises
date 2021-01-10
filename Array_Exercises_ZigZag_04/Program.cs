using System;
using System.Linq;
namespace Array_Exercises_ZigZag_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int[] arr2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                var elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    arr[i] = elements[0];
                    arr2[i] = elements[1];
                }
                else
                {
                    arr[i] = elements[1];
                    arr2[i] = elements[0];
                }
            }
            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine(string.Join(" ", arr2));
        }
    }
}
