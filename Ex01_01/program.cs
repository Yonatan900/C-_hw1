using System;

namespace Ex01_01
{
    public class Program
    {
        private const int k_NumOfInputs = 3;
        private static int[] s_BinaryInputNumbersHolder;
        private static int[] s_BinaryInputNumbersHolderToDecimal;

        static void Main()
        {
            runProgram();
        }

        static void runProgram()
        {
            readInputNumbers(k_NumOfInputs, out s_BinaryInputNumbersHolder, out s_BinaryInputNumbersHolderToDecimal);
            printFunctionOutputData(s_BinaryInputNumbersHolder, s_BinaryInputNumbersHolderToDecimal);
        }

        static void printFunctionOutputData(int[] i_InputNumbersBinary, int[] i_InputNumbersDecimal)
        {
            orderDecIntArray(ref i_InputNumbersBinary);
            orderDecIntArray(ref i_InputNumbersDecimal);
            Console.WriteLine("The decimal represention of the numbers are:");

            foreach (int num in i_InputNumbersDecimal)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("There are {0} number that are power of 2", countPowersOfTwo(i_InputNumbersDecimal));
            Console.WriteLine("There are {0} zeroes in average in input.", countPowersOfTwo(i_InputNumbersBinary));
            Console.WriteLine("There are {0} ones in average in input.", countPowersOfTwo(i_InputNumbersBinary));
            Console.WriteLine("There are {0} numbers devided by 4.", countPowersOfTwo(i_InputNumbersDecimal));
            Console.WriteLine("There are {0} numbers where the digits are decreasing sequence.", countPowersOfTwo(i_InputNumbersDecimal));
            Console.WriteLine("There are {0} palindrome numbers.", countPowersOfTwo(i_InputNumbersDecimal));
        }

        static void readInputNumbers(int i_NumOfInputsToRead, out int[] o_BinaryInputHolder, out int[] o_DecimalInputOrder)
        {
            int binaryRepresentOfInputNumber;

            o_BinaryInputHolder = new int[i_NumOfInputsToRead];
            o_DecimalInputOrder = new int[i_NumOfInputsToRead];
            Console.WriteLine("Please enter 3 binary numbers,\neach 8 digits.");

            for (int i = 0; i < i_NumOfInputsToRead; ++i)
            {
                o_DecimalInputOrder[i] = getSingleDecimalInputFromUser(out binaryRepresentOfInputNumber);
                o_BinaryInputHolder[i] = binaryRepresentOfInputNumber;
            }
        }

        static int getSingleDecimalInputFromUser(out int o_BinaryRepresentaionHolder)
        {
            o_BinaryRepresentaionHolder = getValidBinaryNumberFromUser();

            return convertToDecimal(o_BinaryRepresentaionHolder);
        }

        static int convertToDecimal(int i_BinaryNumber)
        {
            int decimalValueOfNumber = 0;
            int multipleTimesOfTwo = 1;

            while (i_BinaryNumber > 0)
            {
                decimalValueOfNumber += multipleTimesOfTwo * (i_BinaryNumber % 10);
                i_BinaryNumber /= 10;
                multipleTimesOfTwo *= 2;
            }

            return decimalValueOfNumber;
        }

        static int getValidBinaryNumberFromUser()
        {
            int validBinaryNumber;
            string inputNumber = Console.ReadLine();

            while (!checkNumberValidity(inputNumber, out validBinaryNumber))
            {
                Console.WriteLine("Your input should be 8 digits binary number only!");
                inputNumber = Console.ReadLine();
            }

            return validBinaryNumber;
        }

        static bool checkNumberValidity(string i_InputToCheck, out int o_BinaryNumber)
        {
            bool representANumber = int.TryParse(i_InputToCheck, out o_BinaryNumber);
            bool oneByteLength = i_InputToCheck.Length == 8;
            bool representABinaryNumber = doesStringRepBinary(i_InputToCheck);
            bool o_IsInputValid = representANumber && oneByteLength && representABinaryNumber;

            return o_IsInputValid;
        }

        static bool doesStringRepBinary(string i_StringToCheck)
        {
            bool representBinary = true;

            foreach (char c in i_StringToCheck)
            {
                if (c != '0' && c != '1')
                {
                    representBinary = false;
                    break;
                }
            }

            return representBinary;
        }

        static void orderDecIntArray(ref int[] io_IntegerNumbersArray)
        {
            Array.Sort(io_IntegerNumbersArray);
            Array.Reverse(io_IntegerNumbersArray);
        }

        static int countPowersOfTwo(int[] i_IntegerNumbersArray)
        {
            int numberOfTwosPowers = 0;

            foreach (int number in i_IntegerNumbersArray)
            {
                if ((number != 0) && ((number & (number - 1)) == 0))
                {
                    numberOfTwosPowers += 1;
                }
            }

            return numberOfTwosPowers;
        }

        static int zeroesAverage(int[] i_IntegerNumbersArray)
        {
            int numberOfTwosPowers = 0;

            foreach (int number in i_IntegerNumbersArray)
            {
                if ((number != 0) && ((number & (number - 1)) == 0))
                {
                    numberOfTwosPowers += 1;
                }
            }

            return numberOfTwosPowers;
        }

        static int onesAverage(int[] i_IntegerNumbersArray)
        {
            int numberOfTwosPowers = 0;

            foreach (int number in i_IntegerNumbersArray)
            {
                if ((number != 0) && ((number & (number - 1)) == 0))
                {
                    numberOfTwosPowers += 1;
                }
            }

            return numberOfTwosPowers;
        }

        static int countDigitAppearanceInNumber(char i_Digit, int i_OriginalNumber)
        {
            int countAppearance = 0;

            foreach (char c in i_StringToCheck)
            {
                if (c != '0' && c != '1')
                {
                    representBinary = false;
                    break;
                }
            }
        }

        static int countDevidedByFour(int[] i_IntegerNumbersArray)
        {
            int numberOfTwosPowers = 0;

            foreach (int number in i_IntegerNumbersArray)
            {
                if ((number != 0) && ((number & (number - 1)) == 0))
                {
                    numberOfTwosPowers += 1;
                }
            }

            return numberOfTwosPowers;
        }

        static int countDecOrder(int[] i_IntegerNumbersArray)
        {
            int numberOfTwosPowers = 0;

            foreach (int number in i_IntegerNumbersArray)
            {
                if ((number != 0) && ((number & (number - 1)) == 0))
                {
                    numberOfTwosPowers += 1;
                }
            }

            return numberOfTwosPowers;
        }

        static int countPalindrome(int[] i_IntegerNumbersArray)
        {
            int numberOfTwosPowers = 0;

            foreach (int number in i_IntegerNumbersArray)
            {
                if ((number != 0) && ((number & (number - 1)) == 0))
                {
                    numberOfTwosPowers += 1;
                }
            }

            return numberOfTwosPowers;
        }
    }
}
