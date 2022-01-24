using System;
using System.Collections.Generic;
using ConsoleApp1;

namespace University
{
    internal class University
    {
        public List<Student> students = new List<Student>();
        public void addStudent(Student s) {
            this.students.Add(s);
        }
        public void printStudents(){
            foreach (Student s in this.students) {
                Console.WriteLine(s.FirstName + " " + s.LastName + " " + s.Age);
            }
        }
    }
}
