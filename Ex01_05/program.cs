using System;

namespace Ex01_05
{
    public class Program
    {
        private static String s_sixDigit;

        static void Main()
        {
            runProgram();
        }

        static void runProgram()
        {
            readInputNumber(out s_sixDigit);
            printFunctionOutputData(s_sixDigit);
        }
        static void readInputNumber(out String o_sixDigit)
        {

            Console.WriteLine("Please enter a 6 digit number.");
            o_sixDigit = getValidSixDigitNumberFromUser();

        }

        static String getValidSixDigitNumberFromUser()
        {
            String validSixDigitNumber;
            string inputNumber = Console.ReadLine();

            while (!checkNumberValidity(inputNumber, out validSixDigitNumber))
            {
                Console.WriteLine("Your input should be 6 digits number only!");
                inputNumber = Console.ReadLine();
            }

            return validSixDigitNumber;
        }

        static bool checkNumberValidity(string i_InputToCheck, out String o_SixDigitNumber)
        {
            bool representNumber = int.TryParse(i_InputToCheck, out int _);
            o_SixDigitNumber = i_InputToCheck;
            bool sixDigitLength = i_InputToCheck.Length == 6;
            bool o_IsInputValid = representNumber && sixDigitLength;

            return o_IsInputValid;
        }





        static void printFunctionOutputData(String i_sixDigit)
        {
            int unitsPlaceDigit = i_sixDigit[5];


            Console.WriteLine("There are {0} digits that are bigger than {1}", countBiggerThanUnitsDigit(i_sixDigit), unitsPlaceDigit);
            Console.WriteLine("There lowest digit is {0}.", getLowestDigit(i_sixDigit));
            Console.WriteLine("There are {0} digits that are divisble By three.", countDivisbleByThree(i_sixDigit));
            Console.WriteLine("There digits average is {0}.", getDigitsAverage(i_sixDigit));

        }

        static int countBiggerThanUnitsDigit(String i_sixDigit)
        {


            char unitsDigit = i_sixDigit[5];
            int count = 0;

            for (int i = 0; i < 5; i++)
            {
                if (i_sixDigit[i] > unitsDigit)
                {
                    count++;
                }
            }

            return count;


        }
        static char getLowestDigit(String i_sixDigit)
        {
            char minDigit = i_sixDigit[0];
            foreach (char digit in i_sixDigit)
            {
                if (minDigit > digit)
                {
                    minDigit = digit;
                }

            }



            return minDigit;
        }



        static int countDivisbleByThree(string i_sixDigit)
        {
            int count = 0;
            foreach (char digitChar in i_sixDigit)
            {
                int digit = (int)Char.GetNumericValue(digitChar);

                if (digit % 3 == 0)
                {
                    count++;
                }
            }

            return count;
        }
        static double getDigitsAverage(string i_StringToCheck)
        {
            double digitsSum = 0;
            double digitsAverage;
            foreach (char digitChar in i_StringToCheck)
            {
                digitsSum += Char.GetNumericValue(digitChar);
            }

            digitsAverage = digitsSum / 6;



            return digitsAverage;
        }


    }
}
