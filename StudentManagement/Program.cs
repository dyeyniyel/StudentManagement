using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            StudentManager studentManager = new StudentManager();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            studentManager.addStudent(
                new Student(studentManager.GetCount(), "Urvish", 1, "121 Trudell st", "416294")
                );

            Application.Run(new Form1(studentManager));
        }
    }
}
