namespace ConsoleApp1
{
    // Abstract class and methods
    abstract class Animal
    {
        public Animal()
        {
            System.Console.WriteLine("Animal Created");
        }

        public int FeetCount { get; set; }
        public abstract void makeSound(); 
        public abstract void Move();
        public virtual string Test()
        {
            return "Test";
        }
    }
}
