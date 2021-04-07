using System;

namespace Methods_LabNEx_EvenByOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            
            int result=GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(result);
        }

        private static int GetSumOfOddDigits(int num)
        {
            int oddSum = 0;

            while (num > 0)
            {
                int lastDigit = num % 10;
                num = num / 10;

                if (lastDigit % 2 != 0)
                {
                    oddSum += lastDigit;
                }
            }
            return oddSum;
        }

        private static int GetSumOfEvenDigits(int num)
        {
            int evenSum = 0;

            while (num > 0)
            {
                int lastDigit = num % 10;
                num = num / 10;

                if (lastDigit % 2 == 0)
                {
                    evenSum += lastDigit;
                }
            }
            return evenSum;
        }

        private static int GetMultipleOfEvenAndOdds(int num)
        {
            int evenSum = GetSumOfEvenDigits(num);
            int oddSum = GetSumOfOddDigits(num);
            return evenSum * oddSum;
        }
    }
}
