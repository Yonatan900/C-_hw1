using System;

namespace Ex01_02
{
	public class Program
	{
        private const int k_StartNumOfAsteriskInLine = 1;
        private const int k_MaxNumOfAsteriskInLine = 9;

        static void Main()
		{

			PrintStartersDiamond();
		}

		static void PrintStartersDiamond()
		{
            PrintDiamondRecursive(k_StartNumOfAsteriskInLine, k_MaxNumOfAsteriskInLine);

        }

		public static void PrintDiamondRecursive(int i_NumOfAsterisk, int i_MaxNumOfAsterisk)
		{
            PrintDiamondLine(i_NumOfAsterisk, i_MaxNumOfAsterisk);

            if (i_NumOfAsterisk < i_MaxNumOfAsterisk)
			{
                PrintDiamondRecursive(i_NumOfAsterisk + 2, i_MaxNumOfAsterisk);
                PrintDiamondLine(i_NumOfAsterisk, i_MaxNumOfAsterisk);
            }
		}

        static void PrintDiamondLine(int i_NumOfAsterisk, int i_MaxNumOfAsterisk)
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

