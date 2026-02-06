using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Yossi", 12345678, 18);
            CollegeStudent cs1 = new CollegeStudent("tal", 24681357, 24, "math",97);

            Console.WriteLine(s1.GetStudentInfo());
            s1.setStudentName("dan");
            s1.setAge(19);

            Console.WriteLine("----------------------------");
            s1.DisplayInformation();
            cs1.DisplayInformation();
        }
    }
}
