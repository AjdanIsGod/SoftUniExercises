using System;

namespace Methods_LabNEx_MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            Solve(firstNum,operation,secondNum);
        }

        private static void Solve(int firstNum,char oper, int secondNum)
        {
            switch (oper)
            {
                case '/':
                    Console.WriteLine(firstNum/secondNum);
                    break;
                case '*':
                    Console.WriteLine(firstNum*secondNum);
                    break;
                case '+':
                    Console.WriteLine(firstNum+secondNum);
                    break;
                case '-':
                    Console.WriteLine(firstNum-secondNum);
                    break;
                default:
                    break;
            }
        }
    }
}
