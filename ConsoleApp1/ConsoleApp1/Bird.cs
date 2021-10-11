using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Bird : Animal
    {

    }
    class Swan : Bird
    {
        public override void makeSound()
        {
            throw new NotImplementedException();
        }
        public override void Move()
        {
            Console.WriteLine("Swan Flys");
        }
    }
}
