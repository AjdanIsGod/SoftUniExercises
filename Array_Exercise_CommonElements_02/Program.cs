using System;
using System.Linq;

namespace Array_Exercise_CommonElements_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split().ToArray();
            string[] second = Console.ReadLine().Split().ToArray();
            for (int i = 0; i < second.Length; i++)
            {
                for (int j = 0; j < first.Length; j++)
                {
                    if (second[i]==first[j])
                    {
                        Console.Write(first[j] + " ");
                        break;
                    }
                }
            }
        }
    }
}
