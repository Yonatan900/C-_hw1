using System;
using Microsoft.AspNetCore.Components.Forms;

namespace Ex01_04
{
	public class Program
	{
		static void Main()
		{
			doSomething();

        }

		static void doSomething()
		{
			string validInput;


            validInput = receiveInput();

			PrintFunctionOutputData(validInput);

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

		static void PrintFunctionOutputData(string i_InputFromUser)
		{
			Console.WriteLine("The input is {0} palindrome", isPalidrome(i_InputFromUser));

			if (onlyDigits(i_InputFromUser))
			{
                Console.WriteLine("The input is {0} by 3", "devided");
            }
			else
			{
                Console.WriteLine("The input has {0} uppercase letters", "8");
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

    }
}

