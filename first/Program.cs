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

            Point p1 = new Point { X = 1, Y = 1 };
            Point p2 = new Point { X = 2, Y = 2 };

            // Assigning reference of p2 to p1
            p1 = p2;

            // Modifying p2
            p2.X = 5;
            p2.Y = 10;

            Console.WriteLine("Point p1: X = " + p1.X + ", Y = " + p1.Y);
            Console.WriteLine("Point p2: X = " + p2.X + ", Y = " + p2.Y);


        }

        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }


    }
}
