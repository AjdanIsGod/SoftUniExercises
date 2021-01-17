using System;
using System.Linq;
namespace Array_Exercises_Kamino_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLenght = int.Parse(Console.ReadLine());
            int lenght = 0; //Winning subsequence
            int sum = 0; //Winning sum
            int startIndex = -1; // Winning index
            int row = 0; //Variable to keep track of rows , because it must be printed out in the end
            int currentRow = 1;
            int[] DNA = new int[dnaLenght]; //Storing the elements of the input array so it can be printed out later.
            while (true)
            {
                string line = Console.ReadLine();
                if (line=="Clone them!")
                {
                    break;
                }
                //RemoveEmptyEntries removes an empty space between characters like "!" , because they are added by the buffer by default and will break the code if left there.
                int[] currentDNA = line.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int currentSum = 0;
                for (int i = 0; i < currentDNA.Length; i++) //Looping through the input to increase the sum.
                {
                    if (currentDNA[i]==1)
                    {
                        currentSum++;
                    }
                }
                if (currentRow==1)
                {
                    DNA = currentDNA;
                    row = currentRow;
                    sum = currentSum;
                }
                int currentStartIndex = -1;
                int currentLenght = 0;
                bool isFound = false;
                for (int i = 0; i < currentDNA.Length; i++) // Looping for the index.
                {
                    if (currentDNA[i]==1) //Here we set the current index to be "i" , so we can check for the leftmost later.
                    {
                        if (!isFound)
                        {
                            currentStartIndex = i;
                        }
                        currentLenght++;
                        if (currentLenght > lenght) //Checking the longest subsequence.
                        {
                            lenght = currentLenght;
                            startIndex = currentStartIndex;
                            sum = currentSum;
                            row = currentRow;
                            DNA = currentDNA;
                        }
                        else if (currentLenght == lenght)
                        {
                            if (currentStartIndex < startIndex) //Checking the most leftmost index.
                            {
                                lenght = currentLenght;
                                startIndex = currentStartIndex;
                                sum = currentSum;
                                row = currentRow;
                                DNA = currentDNA;
                            }
                        }
                    }
                    else
                    {
                        currentStartIndex = -1;
                        currentLenght = 0;
                        isFound = false;
                    }
                }
                currentRow++; 
            }
            Console.WriteLine($"Best DNA sample {row} with sum: {sum}.");
            Console.WriteLine(string.Join(" ",DNA));
        }
    }
}
