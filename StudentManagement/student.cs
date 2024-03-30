using System;

namespace StudentManagement
{
    public class Student
    {
        private static int nextId = 1;

        public int Id { get; private set; }
        public string Name { get; set; }
        public int Sem { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public Student(string name, int sem, string address, string phoneNumber)
        {
            Id = nextId++;
            Name = name;
            Sem = sem;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Semester: {Sem}, Address: {Address}, Phone: {PhoneNumber}";
        }
    }
}
