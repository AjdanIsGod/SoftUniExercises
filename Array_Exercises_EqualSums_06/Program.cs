using System;
using System.Linq;
namespace Array_Exercises_EqualSums_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (arr.Length==1)
            {
                Console.WriteLine(0);
                return;
            }
            int leftSum=0;
            int rightSum=0;
            for (int i = 0; i < arr.Length; i++)
            {
                leftSum = arr.Take(i).Sum(); //Take gets a given amount of elements from the array from the first element outwards.
                rightSum = arr.Skip(i + 1).Sum(); //Skip gets the elements after a given index in the array.
                if (leftSum==rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
