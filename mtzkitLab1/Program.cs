using System;
using ConsoleApp1;
using System.Collections.Generic;

namespace University
{
    internal class Program
    {
        static void ShowMainMenu(University university) {

            Console.WriteLine("Main menu:");
            Console.WriteLine("1.Add student");
            Console.WriteLine("2.Remove student");
            Console.WriteLine("3.Show students list");
            Console.Write(">:");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1: university.addStudent(CreateStudentFromUserInput()); ShowMainMenu(university); break;
                //case 2: removeStudent();break;
                case 3: university.printStudents(); ShowMainMenu(university); break;
            }
        }
        static Student CreateStudentFromUserInput()
        {
            Console.Write("First Name >> ");
            string firstName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Last Name >> ");
            string lastName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Age >> ");
            int age = Convert.ToInt32(Console.ReadLine());
            return new Student(firstName, lastName, age);
        }
        static void Main(string[] args)
        {
            University university = new University();
            ShowMainMenu(university);
        }
    }
}
