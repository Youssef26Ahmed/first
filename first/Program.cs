

using System;
using System.ComponentModel;
using System.Drawing;
using System.Dynamic;
using System.Globalization;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace AssignmentOne
{
    public class Employee
    {
        public int Id { get; set; }

        public int GetInt()
        {
            return Id;
        }
        public void SetInt(int _Id)
        {
           Id = _Id;
        }
        public string Name { get; set; }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string _Name)
        {
            Name = _Name;
        }

        private char _gender;
        public char Gender
        {
            get { return _gender; }
            set
            {
                if (value == 'M' | value == 'F')
                    _gender = value;
                else
                    Console.WriteLine("Invalid gender. Please enter 'M' for Male or 'F' for Female.");
            }
        }
        public Char GetGender()
        {
            return Gender;
        }
        public void SetGender(Char _Gender)
        {
            if (_Gender == 'M' | _Gender == 'F')
                Gender = _Gender;
            else
                Console.WriteLine("Invalid gender");
        }
        public SecurityPrivilege SecurityLevel { get; set; }
        public SecurityPrivilege GetSecurityLevel()
        {
            return SecurityLevel;
        }
        public void SetSecurityLevel(SecurityPrivilege _SecurityLevel)
        {
            SecurityLevel = _SecurityLevel;
        }
        public int Salary { get; set; }
        public int GetSalary()
        {
            return Salary;
        }
        public void SetSalary(int _Salary)
        {
            Salary = _Salary;
        }

        public HiringDate HireDate { get; set; }
        public HiringDate GetHireDate()
        {
            return HireDate;
        }
        public void SetHireDate(HiringDate _HireDate)
        {
            HireDate = _HireDate;
        }

        public Employee(int id, string name, char gender, SecurityPrivilege securityLevel, int salary, HiringDate hireDate)
        {
            Id = id;
            Name = name;
            Gender = gender;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
        }
        public override string ToString()
        {
            return $"ID: {Id}\nName: {Name}\nGender: {Gender}\nSecurity Level: {SecurityLevel}\nSalary: {Salary}\nHire Date: {HireDate.Day}/{HireDate.Month}/{HireDate.Year}";

        }

        public string FormattedSalary()
        {
            return string.Format("$" + Salary);
        }

    }



    public class HiringDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        // Constructor to initialize the fields
        public HiringDate(int day, int month, int year)
        {
            if (day < 1 || day > 31 || month < 1 || month > 12 || year > 2024)
               Console.WriteLine("Invalid values.");

            Day = day;
            Month = month;
            Year = year;
        }
    }


    struct Point
    {
        public int X;
        public int Y;
    }
    struct Person
    {
        public string Name;
        public int Age;
    }

    public enum SecurityPrivilege
    {
        guest, Developer, secretary, DBA
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part 01
            #region 1.
            //1.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program
            //that takes two points as input from the user and calculates the distance between them.

            //Console.WriteLine("Enter the coordinates of the first point:");
            //int.TryParse(Console.ReadLine(), out int x1);
            //int.TryParse(Console.ReadLine(), out int y1);
            //Point point1 = new Point {X= x1,Y = y1};

            //Console.WriteLine("Enter the coordinates of the second point:");
            //int.TryParse(Console.ReadLine(), out int x2);
            //int.TryParse(Console.ReadLine(), out int y2);
            //Point point2 = new Point { X = x2, Y = y2 };

            //double distance = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
            //Console.WriteLine($"The distance between the two points is: {distance:F2}");
            #endregion
            #region 2.
            //2.Create a struct called "Person" with properties "Name" and "Age". Write a C# program 
            //that takes details of 3 persons as input
            //from the user and displays the name and age of the oldest person.

            //Person[] people = new Person[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter details of person {i + 1}:");
            //    Console.Write("Name: ");
            //    people[i].Name = Console.ReadLine();
            //    Console.Write("Age: ");
            //    people[i].Age = int.Parse(Console.ReadLine());
            //}

            //Person oldestPerson = people[0];
            //for (int i = 1; i < 3; i++)
            //{
            //    if (people[i].Age > oldestPerson.Age)
            //    {
            //        oldestPerson = people[i];
            //    }
            //}

            //Console.WriteLine($"The oldest person is {oldestPerson.Name} with an age of {oldestPerson.Age}");
            #endregion
            #endregion

            #region Part 02
            Employee employee = new Employee(1, "diaa ahmed", 'x', SecurityPrivilege.Developer, 85000, new HiringDate(27, 10, 2022));

            Console.WriteLine(employee.ToString());

            Console.WriteLine("Salary: " + employee.FormattedSalary());

            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee(2, "Ahmed rashed", 'M', SecurityPrivilege.DBA, 95000, new HiringDate(21, 10, 2021));
            EmpArr[1] = new Employee(3, "rashed mohamed", 'M', SecurityPrivilege.guest, 35000, new HiringDate(11, 11, 2020));
            EmpArr[2] = new Employee(4, "ali hamed", 'M', SecurityPrivilege.DBA, 120000, new HiringDate(12, 2, 2023));

            Array.Sort(EmpArr, (e1, e2) =>
            {
                if (e1.HireDate.Year != e2.HireDate.Year)
                    return e1.HireDate.Year.CompareTo(e2.HireDate.Year);
                if (e1.HireDate.Month != e2.HireDate.Month)
                    return e1.HireDate.Month.CompareTo(e2.HireDate.Month);
                return e1.HireDate.Day.CompareTo(e2.HireDate.Day);
            });


            Console.WriteLine("--------------------------------------");
            Console.WriteLine("sorted array");

            foreach (Employee emp in EmpArr)
            {
                Console.WriteLine(emp.ToString());
                Console.WriteLine();

            }

            //no boxing or unboxing occurs during sorting because all
            //the properties(Year, Month, Day) are value types(int),
            //and the CompareTo method operates directly on these value types.
           
            #endregion
        }


    }
}
