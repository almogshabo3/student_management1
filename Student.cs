using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    public class Student : IPerson
    {
        protected string studentName;
        protected int studentID;
        protected int age;

        public Student(string studentName, int studentID, int age)
        {
            this.studentName = studentName;
            this.studentID = studentID;
            this.age = age;
        }

        public string getStudentName() {  return this.studentName; }
        public void setStudentName(string studentName) { this.studentName = studentName; }
        public int getStudentID() { return this.studentID; }
        public void setStudentID( int studentID) { this.studentID = studentID;}
        public int getAge() { return this.age; }
        public void setAge(int age) { this.age = age; }

        public virtual void DisplayInformation()
        {
            Console.WriteLine($"name: {this.studentName} | id: {this.studentID} | age: {this.age}");
        }
        public (string,int,int) GetStudentInfo()
        {
            return (this.studentName, this.studentID, this.age);
        }

    }
}
