using System;
using System.Linq;
namespace Array_Exercise_LadyBugs_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladyBugs = new int[fieldSize];
            int[] fieldIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < ladyBugs.Length; i++)
            {
                for (int j = 0; i < fieldIndexes.Length; i++)
                {
                    int pos = fieldIndexes[j];
                    if (ladyBugs[i] == pos)
                    {
                        ladyBugs[i] = 1;
                    }
                }
                
            }
            while (true)
            {
                string line = Console.ReadLine();
                string[] tokens = line.Split();
                if (line=="end")
                {
                    break;
                }
                int ladyBugIndex = int.Parse(tokens[0]);
                string direction = tokens[1].ToString();
                int flyLenght = int.Parse(tokens[2]);
                if (ladyBugs[ladyBugIndex]==1)
                {
                    if (direction=="left")
                    {
                        int fly = 1;
                        int landing = ladyBugIndex - flyLenght * fly;
                        while (landing>=0&&ladyBugs[landing]==1)
                        {
                            if (flyLenght==0)
                            {
                                break;
                            }
                            fly++;
                            landing = ladyBugIndex - flyLenght * fly;
                        }
                        if (landing>=0)
                        {
                            ladyBugs[landing] = 1;
                        }
                        if (flyLenght!=0)
                        {
                            ladyBugs[ladyBugIndex] = 0;
                        }
                    }
                    else if (direction=="right")
                    {
                        int fly = 1;
                        int landing = ladyBugIndex + flyLenght * fly;
                        while (landing<fieldSize&&ladyBugs[landing]==1)
                        {
                            if (flyLenght==0)
                            {
                                break;
                            }
                            fly++;
                            landing = ladyBugIndex + flyLenght * fly;
                        }
                        if (landing<fieldSize)
                        {
                            ladyBugs[landing] = 1;
                        }
                        if (flyLenght!=0)
                        {
                            ladyBugs[ladyBugIndex] = 0;
                        }
                    }
                }
            }
            foreach (var item in ladyBugs)
            {
                Console.Write(item+ " ");
            }
        }
    }
}
