using System;

namespace PerfectNumberChecker
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CheckAndPrintPerfectNumber(ReadPositiveNumber("Enter a positive number:"));
        }

        private static int ReadPositiveNumber(string message)
        {
            int number;
            bool isValidInput;

            do
            {
                Console.WriteLine(message);
                isValidInput = int.TryParse(Console.ReadLine(), out number);

                if (!isValidInput || number <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                    isValidInput = false;
                }
            } while (!isValidInput);

            return number;
        }

        private static bool IsPerfectNumber(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            int sumOfDivisors = 0;

            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sumOfDivisors += i;
                }
            }

            return sumOfDivisors == number;
        }

        private static void CheckAndPrintPerfectNumber(int number)
        {
            if (IsPerfectNumber(number))
            {
                Console.WriteLine($"{number} is a perfect number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a perfect number.");
            }
        }
    }
}