using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class StudentManager
    {
        private List<Student> students;

        public StudentManager()
        {
            this.students = new List<Student>();
        }

        public void addStudent(Student student)
        {
            students.Add(student);
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public int GetCount() { return students.Count + 1; }

        public Student GetStudent(int id)
        {
            return students[id - 1];
        }

        public bool UpdateStudent(Student student)
        {
            students[student.Id - 1] = student;

            return true;

        }

    }
}
