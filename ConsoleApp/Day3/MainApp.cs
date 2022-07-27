using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Day3
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Start");
            //Student student = new Student();
            //student.DisplayStudentDetails();
            //student.SetStudentDetails(1000, "RK", 24);
            //student.DisplayStudentDetails();

            var student = new Student();
            student.SetStudentDetails(2000, "Aniket", 25);
            student.DisplayStudentDetails();

            //anonymous Object Behaviour or creation
            new Student().SetStudentDetails(3000, "Tejas", 24);
            new Student().DisplayStudentDetails();
        }
    }
}
