using System;
using System.Drawing;

namespace first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            //first Q

            /*Console.WriteLine("Enter The Number:");
            int Num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Number is: " + Num);*/

            //second Q
            // Declare and initialize two integer variables
            /*int x = 10;
            int y = 5;

            // Display the initial values
            Console.WriteLine($"Before Assigning:\nx = {x}, y = {y}");

            // Assign the value of x to y
            y = x;

            // Display the values after assignment
            Console.WriteLine($"After Assigning:\nx = {x}, y = {y}");

            // Modify the value of x
            x = 20;

            // Display the values after modifying x
            Console.WriteLine($"After Modifying x:\nx = {x}, y = {y}");*/


            //Third Q
            /*
            Point p1 = new Point { X = 1, Y = 1 };
            Point p2 = new Point { X = 2, Y = 2 };

            // Assigning reference of p2 to p1
            p1 = p2;

            // Modifying p2
            p2.X = 5;
            p2.Y = 10;

            Console.WriteLine("Point p1: X = " + p1.X + ", Y = " + p1.Y);
            Console.WriteLine("Point p2: X = " + p2.X + ", Y = " + p2.Y);
            */

            #region 1

            /* Console.Write("Enter a number: ");
             int number;

             // Check if the input is a valid integer
             if (int.TryParse(Console.ReadLine(), out number))
             {
                 // Check if the number is divisible by both 3 and 4
                 if (number % 3 == 0 && number % 4 == 0)
                 {
                     Console.WriteLine("yes");
                 }
                 else
                 {
                     Console.WriteLine("no");
                 }
             }
             else
             {
                 Console.WriteLine("Invalid input. Please enter a valid integer.");
             }*/
            #endregion
            //////////////////////////////////////
            #region 2

            /* Console.Write("Please enter an integer: ");
             int number1 = Convert.ToInt32(Console.ReadLine());

             if (number1 < 0)
             {
                 Console.WriteLine("negative");
             }
             else
             {
                 Console.WriteLine("positive");
             }
            */
            #endregion

            #region 3
            /*
            // Prompt the user to enter three integers
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            int num3 = int.Parse(Console.ReadLine());

            // Find the maximum and minimum values
            int max = Math.Max(num1, Math.Max(num2, num3));
            int min = Math.Min(num1, Math.Min(num2, num3));

            // Print the results
            Console.WriteLine("The maximum number is: " + max);
            Console.WriteLine("The minimum number is: " + min);

            */
            #endregion

            #region 4
            /*
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is an even number.");
            }
            else
            {
                Console.WriteLine($"{number} is an odd number.");
            }
            */
            #endregion

            #region 5
            /*
            Console.Write("Enter a character: ");
            char ch = Char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine(); // For new line after input

            if (!Char.IsLetter(ch))
            {
                Console.WriteLine("Please enter a valid alphabet.");
            }
            else
            {
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    Console.WriteLine($"{ch} is a vowel.");
                }
                else
                {
                    Console.WriteLine($"{ch} is a consonant.");
                }
            }
            */
            #endregion

            #region 7
            /*
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Multiplication table for {number}:");
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{number * i}"+ " ");
            }
            */
            #endregion

            #region 8
            /*
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

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

            #region 9
            /*
            Console.Write("Enter the base number: ");
            int baseNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the exponent: ");
            int exponent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Power series of {baseNumber} to the power of {exponent}:");
            for (int i = 0; i <= exponent; i++)
            {
                Console.WriteLine($"{Math.Pow(baseNumber, i)}");
            }
            */
            #endregion

            #region 11
            /*
            Console.Write("Enter the month number (1-12): ");
            int month = Convert.ToInt32(Console.ReadLine());

            int days = DateTime.DaysInMonth(DateTime.Now.Year, month);

            Console.WriteLine($"The number of days in month {month} is: {days}");
            */
            #endregion

            #region 18

            //effiency level

            Console.Write("Enter the working hours: ");
            int hour = Convert.ToInt32(Console.ReadLine());

            if (2 <= hour && hour < 3)
            {
                Console.Write("highly efficient");
            }
            if (3 <= hour && hour < 4)
            {
                Console.Write("increase their speed.");
            }

            if (4 <= hour && hour <= 5)
            {
                Console.Write("should take training.");
            }
            if (hour > 5)
            {
                Console.Write("leave the company.");
            }


            #endregion



        }
        /*
        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        */
    }
}
