using System;
using System.Linq;
namespace Array_Exercise_MaxSequenceEqual_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 0; //This variable is the sequence(number of elements equal to each other). 
            int winningCounter = 0; //This variable is the max sequence.
            string number = ""; //Max sequence is stored under this string value.
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i]==arr[i+1]) //If the current element is equal to the next element , we "add" a value to the sequence.
                {
                    counter++;
                    if (counter>winningCounter) //If the first sequence is larger than the max sequence , the max sequence gets the value of the first sequence.
                    {
                        winningCounter = counter;
                        number = arr[i].ToString();
                    }
                }
                else
                {
                    counter = 0;
                }
            }
            for (int i = 0; i <= winningCounter; i++)
            {
                Console.Write(number + " ");
            }
        }
    }
}
