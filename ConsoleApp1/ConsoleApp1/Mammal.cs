using System;

namespace ConsoleApp1
{
    abstract class Mammal : Animal 
    {
    
    }

    class Cat : Mammal
    {
        public override void makeSound()
        {
            throw new System.NotImplementedException();
        }

        public override void Move()
        {
            throw new System.NotImplementedException();
        }
    }


    class Tiger : Mammal
    {
        public override void makeSound()
        {
            Console.WriteLine("Rawr!");
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}
