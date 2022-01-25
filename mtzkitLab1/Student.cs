namespace ConsoleApp1
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Student(string FirstName, string LastName, int Age) {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
        }
    }
}
