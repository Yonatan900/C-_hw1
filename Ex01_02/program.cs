using System;

namespace Ex01_02
{
    public class Program
    {
        private const int k_StartNumOfAsteriskInLine = 1;
        private const int k_MaxNumOfAsteriskInLine = 9;

        static void Main()
        {
            printStartersDiamond();
        }

        static void printStartersDiamond()
        {
            printDiamondRecursive(k_StartNumOfAsteriskInLine, k_MaxNumOfAsteriskInLine);
        }

        public static void printDiamondRecursive(int i_NumOfAsterisk, int i_MaxNumOfAsterisk)
        {
            printDiamondLine(i_NumOfAsterisk, i_MaxNumOfAsterisk);

            if (i_NumOfAsterisk < i_MaxNumOfAsterisk)
            {
                printDiamondRecursive(i_NumOfAsterisk + 2, i_MaxNumOfAsterisk);
                printDiamondLine(i_NumOfAsterisk, i_MaxNumOfAsterisk);
            }
        }

        static void printDiamondLine(int i_NumOfAsterisk, int i_MaxNumOfAsterisk)
        {
            for (int i = 0; i < i_MaxNumOfAsterisk - i_NumOfAsterisk; ++i)
            {
                Console.Write(' ');
            }

            for (int i = 0; i < i_NumOfAsterisk; ++i)
            {
                Console.Write("* ");
            }

            Console.WriteLine("\n");
        }
    }
}
