using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Worker:Person
    {
        public Worker()
        { }

        public Worker(string name, string surname, int age)
        {
            Name = name;
            SurName = surname;
            Age = age;
        }
        public int Salary { get; set; }
    }
}
