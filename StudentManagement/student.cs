namespace StudentManagement
{
    public class Student
    {
        private static int nextId = 1;

        private int id;
        private string name;
        private int sem;
        private string address;
        private string phoneNumber;

        public Student(string name, int sem, string address, string phoneNumber)
        {
            this.id = nextId++;
            this.name = name;
            this.sem = sem;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        public int Id { get => id; }
        public string Name { get => name; set => name = value; }
        public int Sem { get => sem; set => sem = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        // ToString method to display student details
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Semester: {Sem}, Address: {Address}, Phone: {PhoneNumber}";
        }
    }
}
