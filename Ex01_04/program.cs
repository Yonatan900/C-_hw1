using System;

namespace Ex01_04
{
    public class Program
    {
        static void Main()
        {
            runProgram();
        }

        static void runProgram()
        {
            string validInput = receiveInput();
            printFunctionOutputData(validInput);
        }

        static string receiveInput()
        {
            string inputFromUser;

            Console.WriteLine("Please enter 6 chars or 6 digits.");
            inputFromUser = Console.ReadLine();

            while ((!onlyChars(inputFromUser) && !onlyDigits(inputFromUser)) || inputFromUser.Length != 6)
            {
                Console.WriteLine("Your input should be 6 digits only or chars only!");
                inputFromUser = Console.ReadLine();
            }

            return inputFromUser;
        }

        static bool onlyChars(string i_InputToCheck)
        {
            return i_InputToCheck.All(char.IsLetter);
        }

        static bool onlyDigits(string i_InputToCheck)
        {
            return i_InputToCheck.All(char.IsDigit);
        }

        static void printFunctionOutputData(string i_InputFromUser)
        {
            int inputFromUserAsIntegerIfPossible;

            Console.WriteLine("The input is {0} palindrome.", (isPalidrome(i_InputFromUser) ? "a" : "not a"));

            if (int.TryParse(i_InputFromUser, out inputFromUserAsIntegerIfPossible))
            {
                Console.WriteLine("The input is {0} by 3.", (doesDividedByThree(inputFromUserAsIntegerIfPossible) ? "divided" : "not divided"));
            }
            else
            {
                Console.WriteLine("The input has {0} uppercase letters.", countUpperCaseLetters(i_InputFromUser));
            }
        }

        static bool isPalidrome(string i_InputToCheck)
        {
            bool firstAndLastEquals = true;
            bool wrapAPalindrome = true;
            int inputFirstIndex = 0;
            int inputLastIndex = i_InputToCheck.Length - 1;

            if (i_InputToCheck.Length > 1)
            {
                firstAndLastEquals = (i_InputToCheck[inputFirstIndex] == i_InputToCheck[inputLastIndex]);
                wrapAPalindrome = isPalidrome(i_InputToCheck.Substring(inputFirstIndex + 1, inputLastIndex - 1));
            }

            return firstAndLastEquals && wrapAPalindrome;
        }

        static bool doesDividedByThree(int i_InputFromUser)
        {
            return (i_InputFromUser % 3 == 0);
        }

        static int countUpperCaseLetters(string i_InputFromUser)
        {
            int countUpperCase = 0;

            foreach (char c in i_InputFromUser)
            {
                if (char.IsUpper(c))
                {
                    countUpperCase++;
                }
            }

            return countUpperCase;
        }
    }
}
