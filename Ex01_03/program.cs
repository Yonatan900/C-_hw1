using System;
using Ex01_02;

namespace Ex01_03
{
    public class Program
    {
        private const int k_StartNumOfAsteriskInLine = 1;
        private static int s_MaxNumOfAsteriskInLine = 9;

        static void Main()
        {
            printStartersDiamond();
        }

        static void printStartersDiamond()
        {
            s_MaxNumOfAsteriskInLine = getMaxAsterisk();
            Ex01_02.Program.printDiamondRecursive(k_StartNumOfAsteriskInLine, s_MaxNumOfAsteriskInLine);
        }

        static int getMaxAsterisk()
        {
            int numberOfLines;
            string numberOfLinesString;

            Console.WriteLine("Enter number of lines");
            numberOfLinesString = Console.ReadLine();

            while (!int.TryParse(numberOfLinesString, out numberOfLines))
            {
                Console.WriteLine("Only number please.");
            }

            return numberOfLines;
        }
    }
}
