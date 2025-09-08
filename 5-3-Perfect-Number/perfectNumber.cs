
// Using statement to include the System namespace for core functionalities like Console
using System;

// Namespace to organize the code, preventing naming conflicts
namespace PerfectNumberChecker
{
    // The main class that contains the program logic
    internal class Program
    {
        // The entry point of the application
        private static void Main(string[] args)
        {
            // Prompt the user for a number and check if it's a perfect number
            CheckAndPrintPerfectNumber(ReadPositiveNumber("Enter a positive number:"));
        }

        /// <summary>
        /// Prompts the user to enter a positive integer and validates the input.
        /// </summary>
        /// <param name="message">The message to display to the user.</param>
        /// <returns>A validated positive integer.</returns>
        private static int ReadPositiveNumber(string message)
        {
            int number; // Variable to store the user's input
            bool isValidInput; // Flag to check if the input is a valid integer

            // Loop until a positive integer is entered
            do
            {
                Console.WriteLine(message);
                isValidInput = int.TryParse(Console.ReadLine(), out number);

                // Check for both a valid integer and a positive value
                if (!isValidInput || number <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                    isValidInput = false; // Keep the loop running
                }

            } while (!isValidInput);

            return number; // Return the validated number
        }

        /// <summary>
        /// Checks if a number is a perfect number.
        /// A perfect number is a positive integer that is equal to the sum of its proper divisors.
        /// </summary>
        /// <param name="number">The integer to check.</param>
        /// <returns>True if the number is perfect; otherwise, false.</returns>
        private static bool IsPerfectNumber(int number)
        {
            // A number cannot be perfect if it's 1, as it has no proper divisors.
            if (number <= 1)
            {
                return false;
            }

            int sumOfDivisors = 0; // Initialize the sum of divisors

            // Loop from 1 up to half of the number to find proper divisors
            for (int i = 1; i <= number / 2; i++)
            {
                // If 'i' divides the number evenly, it's a divisor
                if (number % i == 0)
                {
                    sumOfDivisors += i; // Add the divisor to the sum
                }
            }

            // A number is perfect if the sum of its divisors equals the number itself
            return sumOfDivisors == number;
        }
        /// <summary>
        /// Checks a number and prints whether it is a perfect number or not.
        /// </summary>
        /// <param name="number">The integer to be checked and printed.</param>
        private static void CheckAndPrintPerfectNumber(int number)
        {
            // Use the IsPerfectNumber function to determine the result
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
