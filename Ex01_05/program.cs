using System;

namespace Ex01_05
{
    public class Program
    {
        private static string s_SixDigit;

        static void Main()
        {
            runProgram();
        }

        static void runProgram()
        {
            readInputNumber(out s_SixDigit);
            printFunctionOutputData(s_SixDigit);
        }

        static void readInputNumber(out string o_SixDigit)
        {
            Console.WriteLine("Please enter a 6 digit number.");
            o_SixDigit = getValidSixDigitNumberFromUser();
        }

        static string getValidSixDigitNumberFromUser()
        {
            string validSixDigitNumber = Console.ReadLine();

            while (!checkNumberValidity(validSixDigitNumber))
            {
                Console.WriteLine("Your input should be 6 digits number only!");
                validSixDigitNumber = Console.ReadLine();
            }

            return validSixDigitNumber;
        }

        static bool checkNumberValidity(string i_InputToCheck)
        {
            bool representNumber = int.TryParse(i_InputToCheck, out _);
            bool sixDigitLength = i_InputToCheck.Length == 6;

            return representNumber && sixDigitLength;
        }

        static void printFunctionOutputData(string i_SixDigit)
        {
            char unitsPlaceDigit = i_SixDigit[5];

            Console.WriteLine("There are {0} digits that are bigger than {1}", countBiggerThanUnitsDigit(i_SixDigit), unitsPlaceDigit);
            Console.WriteLine("There lowest digit is {0}.", getLowestDigit(i_SixDigit));
            Console.WriteLine("There are {0} digits that are divisble By three.", countDivisbleByThree(i_SixDigit));
            Console.WriteLine("There digits average is {0}.", getDigitsAverage(i_SixDigit));
        }

        static int countBiggerThanUnitsDigit(string i_SixDigit)
        {
            char unitsDigit = i_SixDigit[5];
            int countBiggerDigits = 0;

            for (int i = 0; i < 5; i++)
            {
                if (i_SixDigit[i] > unitsDigit)
                {
                    countBiggerDigits++;
                }
            }

            return countBiggerDigits;
        }

        static char getLowestDigit(string i_SixDigit)
        {
            char minDigit = i_SixDigit[0];

            foreach (char digit in i_SixDigit)
            {
                if (minDigit > digit)
                {
                    minDigit = digit;
                }
            }

            return minDigit;
        }

        static int countDivisbleByThree(string i_SixDigit)
        {
            int countDiv = 0;
            int currentDigitOfNumber;

            foreach (char digitChar in i_SixDigit)
            {
                currentDigitOfNumber = (int)char.GetNumericValue(digitChar);

                if (currentDigitOfNumber % 3 == 0)
                {
                    countDiv++;
                }
            }

            return countDiv;
        }

        static double getDigitsAverage(string i_StringToCheck)
        {
            double digitsSum = 0;

            foreach (char digitChar in i_StringToCheck)
            {
                digitsSum += char.GetNumericValue(digitChar);
            }

            return digitsSum / i_StringToCheck.Length;
        }
    }
}
