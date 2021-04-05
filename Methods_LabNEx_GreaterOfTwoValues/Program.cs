using System;

namespace Methods_LabNEx_GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            GetMax();
        }

        private static void GetMax()
        {
            string type = Console.ReadLine();
            if (type=="int")
            {
                var first = int.Parse(Console.ReadLine());
                var second = int.Parse(Console.ReadLine());
                if (first>second)
                {
                    Console.WriteLine(first);
                }
                else
                {
                    Console.WriteLine(second);
                }
            }
            else if (type=="char")
            {
                var first = char.Parse(Console.ReadLine());
                var second = char.Parse(Console.ReadLine());
                if (first>second)
                {
                    Console.WriteLine(first);
                }
                else
                {
                    Console.WriteLine(second);
                }
            }
            else if (type=="string")
            {
                var first = Console.ReadLine();
                var second = Console.ReadLine();
                var greaterString = first.CompareTo(second);
                if (greaterString>0)
                {
                    Console.WriteLine(first);
                }
                else
                {
                    Console.WriteLine(second);
                }
            }
        }
    }
}
