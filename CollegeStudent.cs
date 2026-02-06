using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    public class CollegeStudent : Student , IPerson
    {
        protected string subject;
        protected int average;

        public CollegeStudent(string studentName, int studentID, int age, string subject, int average) : base(studentName, studentID, age)
        {
            this.subject = subject;
            this.average = average;
        }
        public override void DisplayInformation()
        {
            Console.WriteLine($"name: {this.studentName} | id: {this.studentID} | age: {this.age} | subject: {this.subject} | average: {this.average}");
        }
    }
}
