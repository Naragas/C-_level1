namespace HW6_3
{
    internal class Students
    {
        string firstName = null;
        string lastName = null;
        int age = 0;
        int course = 0;
        public Students(string firstName, string lastName, int age, int course)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.course = course;

        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public int Course { get => course; set => course = value; }

        public string showStudent()
        {
            string info = string.Empty;
            return info += $"{LastName} {FirstName}, курс {Course}, возраст {Age}";
        }

    }
}