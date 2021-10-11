using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student:Person
    {
        public string University { get; set; }


        public static implicit operator Worker(Student student)
        {
            return new Worker(student.Name, student.SurName, student.Age);
        }

        public static bool operator <(Student stud1, Student stud2)
        {
            return stud1.Age < stud2.Age;
        }
        public static bool operator >(Student stud1, Student stud2)
        {
            return stud1.Age > stud2.Age;
        }

        public static int operator +(Student stud1, Student stud2)
        {
            return stud1.Age + stud2.Age;
        }
    }
}
