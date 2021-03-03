using System;

namespace Methods_LabNEx_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string prod = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Solve(prod,n);
        }

        private static void Solve(string product,int quantity)
        {
            double price = 0;
            switch (product)
            {
                case "water":
                    price = 1.00;
                    break;
                case "coffee":
                    price = 1.50;
                    break;
                case "coke":
                    price = 1.40;
                    break;
                case "snacks":
                    price = 2.00;
                    break;
                default:
                    break;
            }
            double result = price * quantity;
            Console.WriteLine($"{result:f2}");
        }
    }
}
