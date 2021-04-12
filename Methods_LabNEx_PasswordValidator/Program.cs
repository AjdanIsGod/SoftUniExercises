using System;

namespace Methods_LabNEx_PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string passWord = Console.ReadLine();
            bool digitsOfPassword = PasswordDigits(passWord);
            bool symbolsOfPassword = PasswordSymbols(passWord);
            bool lenghtOfPassword = PasswordLenght(passWord);
            if (digitsOfPassword && !symbolsOfPassword && lenghtOfPassword)
            {
                Console.WriteLine("Password is valid");
            }
            if (!lenghtOfPassword)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (symbolsOfPassword)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!digitsOfPassword)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            
            
        }


        private static bool PasswordDigits(string text)
        {
            bool correctDigits = false;
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    counter++;
                }
            }
            if (counter>=2)
            {
                correctDigits = true;
            }
            return correctDigits;
        }

        private static bool PasswordSymbols(string text)
        {
            bool hasSymbols = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsLetterOrDigit(text[i]))
                {
                    hasSymbols = true;
                }
            }
            return hasSymbols;
        }

        private static bool PasswordLenght(string text)
        {
            bool correctLenght = false;
            if (text.Length>=6&&text.Length<=10)
            {
                correctLenght = true;
            }
            return correctLenght;
        }
    }
}
