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

            PrintStartersDiamond();
        }

        static void PrintStartersDiamond()
        {
            s_MaxNumOfAsteriskInLine = GetMaxAsterisk();
            Ex01_02.Program.PrintDiamondRecursive(k_StartNumOfAsteriskInLine, s_MaxNumOfAsteriskInLine);

        }

        static int GetMaxAsterisk()
        {
            int o_NumberOfLines;
            string numberOfLinesString;

            Console.WriteLine("Enter number of lines");
            numberOfLinesString = Console.ReadLine();
            while(!int.TryParse(numberOfLinesString, out o_NumberOfLines))
            {
                Console.WriteLine("Only number please.");
            }

            return o_NumberOfLines;
        }

    }
}

