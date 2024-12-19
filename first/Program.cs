using System;

namespace second
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            /*
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Numbers from 1 to " + number + ":");
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
            */
            #endregion

            #region 2

            /*
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Multiplication table for {number}:");
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{number * i}");
            }
            */
            #endregion

            #region 3
            /*
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Even numbers between 1 and " + number + " are:");
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            */
            #endregion

            #region 4
            /*
            // Prompt the user to enter the base number
            Console.Write("Enter the base number: ");
            int baseNumber = Convert.ToInt32(Console.ReadLine());

            // Prompt the user to enter the exponent
            Console.Write("Enter the exponent: ");
            int exponent = Convert.ToInt32(Console.ReadLine());

            // Calculate the power
            double result = Math.Pow(baseNumber, exponent);

            // Print the result
            Console.WriteLine($"{baseNumber} raised to the power of {exponent} is {result}");

            */
            #endregion

            #region 5
            /*
            // Declare an array to store the marks of five subjects
            int[] marks = new int[5];
            int total = 0;
            double average, percentage;

            // Prompt the user to enter the marks for each subject
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter marks for subject {0}: ", i + 1);
                marks[i] = int.Parse(Console.ReadLine());
                total += marks[i];
            }

            // Calculate average and percentage
            average = total / 5.0;
            percentage = (total / 500.0) * 100;

            // Display the results
            Console.WriteLine("Total Marks: " + total);
            Console.WriteLine("Average Marks: " + average);
            Console.WriteLine("Percentage: " + percentage + "%");
            */
            #endregion

            #region 6
            /*
            Console.Write("Enter the month number (1-12): ");
            int month = Convert.ToInt32(Console.ReadLine());

            int days = DateTime.DaysInMonth(DateTime.Now.Year, month);

            Console.WriteLine($"Number of days in month {month}: {days}");
            */
            #endregion

            #region 7
            /*
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operation (+, -, *, /):");
            char operation = Console.ReadLine()[0];

            double result = 0;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    return;
            }

            Console.WriteLine($"The result is: {result}");

            */
            #endregion

            #region 8
            /*
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());
            int reversedNumber = 0;

            while (number != 0)
            {
                int remainder = number % 10;
                reversedNumber = (reversedNumber * 10) + remainder;
                number /= 10;
            }

            Console.WriteLine($"Reversed number: {reversedNumber}");
            */
            #endregion

            #region 9
            /*
            Console.Write("Enter the starting number of the range: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the ending number of the range: ");
            int end = Convert.ToInt32(Console.ReadLine());

            FindPrimesInRange(start, end);
            */
            #endregion

            #region 10

            Console.Write("Enter a decimal number: ");
            int decimalNumber = int.Parse(Console.ReadLine());
            int binaryNumber = 0;
            int place = 1;

            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % 2;
                binaryNumber += remainder * place;
                decimalNumber /= 2;
                place *= 10;
            }

            Console.WriteLine("Binary representation: " + binaryNumber);
            #endregion




        }
        /*
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        static void FindPrimesInRange(int start, int end)
        {
            Console.WriteLine($"Prime numbers between {start} and {end} are:");
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
        */
    }
}

