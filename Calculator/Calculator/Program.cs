using System;

namespace Calculator
{
    using System;

    class CalculatorApp
    {
        private static int result = 0; // Running total
        private static string currentOperator = string.Empty; // Current operator
        private static string currentNumber = string.Empty; // Number being entered

        public static void Main(string[] args)
        {
            Console.WriteLine("=== Simple Calculator (Integer Only) ===");
            Console.WriteLine("Instructions:");
            Console.WriteLine("1. Enter numbers and operators one at a time.");
            Console.WriteLine("2. Enter '=' to calculate the result.");
            Console.WriteLine("3. Enter 'C' to clear/reset.");
            Console.WriteLine("4. Enter 'exit' to quit.");
            Console.WriteLine("========================================");

            while (true)
            {
                Console.Write("Enter a number, operator (+, -, *, /), '=' to calculate, or 'C' to clear: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("Exiting the calculator. Goodbye!");
                    break;
                }

                ProcessInput(input);
            }
        }

        private static void ProcessInput(string input)
        {
            if (int.TryParse(input, out int number)) // If the input is a number
            {
                currentNumber += input;
                Console.WriteLine($"Number Entered: {currentNumber}");
            }
            else if ("+-*/".Contains(input)) // If the input is an operator
            {
                if (!string.IsNullOrEmpty(currentNumber))
                {
                    PerformOperation(input[0]);
                    currentOperator = input;
                }
                Console.WriteLine($"Current Total: {result}");
            }
            else if (input == "=") // If the input is '='
            {
                if (!string.IsNullOrEmpty(currentNumber) && !string.IsNullOrEmpty(currentOperator))
                {
                    PerformOperation('=');
                    currentOperator = string.Empty;
                }
                Console.WriteLine($"Result: {result}");
            }
            else if (input.ToLower() == "c") // If the input is 'C' to clear/reset
            {
                Clear();
                Console.WriteLine("Calculator reset.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number, operator, or command.");
            }
        }

        private static void PerformOperation(char nextOperator)
        {
            int number = string.IsNullOrEmpty(currentNumber) ? 0 : int.Parse(currentNumber);

            if (currentOperator == "+")
                result += number;
            else if (currentOperator == "-")
                result -= number;
            else if (currentOperator == "*")
                result *= number;
            else if (currentOperator == "/")
                result = number == 0 ? 0 : result / number; // Handle division by zero
            else if (string.IsNullOrEmpty(currentOperator))
                result = number; // Initialize the first number

            currentNumber = string.Empty; // Reset the current number
        }

        private static void Clear()
        {
            result = 0;
            currentNumber = string.Empty;
            currentOperator = string.Empty;
        }
    }
}
