using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Student
    {

        private int id;
        private string Name;
        private int Sem;
        private string address;
        private string phoneNumber;

        public Student(int id, string name, int sem, string address, string phoneNumber)
        {
            this.Id = id;
            Name = name;
            Sem = sem;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        public string Name1 { get => Name; set => Name = value; }
        public int Sem1 { get => Sem; set => Sem = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public int Id { get => id; set => id = value; }
    }
}
